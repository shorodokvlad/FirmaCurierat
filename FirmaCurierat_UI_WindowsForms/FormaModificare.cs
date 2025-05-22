using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using NivelStocareDate;
using System.Collections;
using LibrarieModele;
using LibrarieModele.Enumerari;
using System.Configuration;
using System.IO;

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormaModificare : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;
        
        ArrayList optiuniSelectate = new ArrayList();
        
        public FormaModificare(int idComanda)
        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);
            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);

            mCmbStareComanda.DataSource = Enum.GetValues(typeof(StareComanda));

            mlblIDComanda.Text = idComanda.ToString();
            mlblIDColet.Text = gestiuneComenzi.GetComanda(idComanda).IDColet.ToString();

            SetareControale();

        }

        public void SetareControale()
        {
            Comanda comanda = gestiuneComenzi.GetComanda(Int32.Parse(mlblIDComanda.Text));

            if (comanda != null)
            {
                mtxtNumeClient.Text = comanda.NumeClient;
                mtxtAdresaLivrare.Text = comanda.AdresaLivrare;
                dtpDataLivrare.Value = comanda.DataLivrare;
                mCmbStareComanda.SelectedItem = comanda.StareComanda;

                foreach (var opt in gpbOptiuniLivrare.Controls)
                {
                    if (opt is CheckBox)
                    {
                        var optiune = opt as CheckBox;
                        foreach (String dis in comanda.OptiuniLivrare)
                            if (optiune.Text == dis)
                            {
                                optiune.Checked = true;
                            }
                    }
                }
            }

            Colet colet = gestiuneColete.GetColet(Int32.Parse(mlblIDColet.Text));

            if (colet != null)
            {
                mtxtDescriere.Text = colet.Descriere;

                nUDGreutate.Text = colet.Greutate.ToString();

                double greutate = double.Parse(nUDGreutate.Text);

                switch (colet.Dimensiune)
                {
                    case DimensiuneColet.Mic:
                        rdbMic.Checked = true;
                        break;
                    case DimensiuneColet.MediuMic:
                        rdbMediuMic.Checked = true;
                        break;
                    case DimensiuneColet.MediuStandard:
                        rdbMediuStandard.Checked = true;
                        break;
                    case DimensiuneColet.MediuMare:
                        rdbMediuMare.Checked = true;
                        break;
                    case DimensiuneColet.MareMica:
                        rdbMareMica.Checked = true;
                        break;
                    case DimensiuneColet.MareStandard:
                        rdbMareStandard.Checked = true;
                        break;
                    case DimensiuneColet.MareMare:
                        rdbMareMare.Checked = true;
                        break;
                    case DimensiuneColet.ExtraMare:
                        rdbExtraMare.Checked = true;
                        break;
                }
            }
        }
            
        private DimensiuneColet GetDimensiuneColetSelectat()
        {
            if (rdbMic.Checked)
                return DimensiuneColet.Mic;
            else if (rdbMediuMic.Checked)
                return DimensiuneColet.MediuMic;
            else if (rdbMediuStandard.Checked)
                return DimensiuneColet.MediuStandard;
            else if (rdbMediuMare.Checked)
                return DimensiuneColet.MediuMare;
            else if (rdbMareMica.Checked)
                return DimensiuneColet.MareMica;
            else if (rdbMareStandard.Checked)
                return DimensiuneColet.MareStandard;
            else if (rdbMareMare.Checked)
                return DimensiuneColet.MareMare;
            else
                return DimensiuneColet.ExtraMare;
        }

        private void CkbOptiuniLivare_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string optiuneSelectata = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                optiuniSelectate.Add(optiuneSelectata);
            else
                optiuniSelectate.Remove(optiuneSelectata);
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            var controale = new FormValidator.ControaleValidare
            {
                CampuriText = new (MetroTextBox, MetroLabel)[]
                {
                    (mtxtNumeClient, mlblEroareNumeClient),
                    (mtxtAdresaLivrare, mlblEroareAdresaLivrare),
                    (mtxtDescriere, mlblEroareDescriere)
                },
                DataLivrarePicker = dtpDataLivrare,
                LabelEroareDataLivrare = mlblEroareDataLivrare,
                LabelEroareGreutate = mlblEroareGreutate,
                GreutateText = nUDGreutate.Text,
                LabelEroareOptiuniLivrare = mlblEroareOptiuniLivrare,
                CheckBoxes = new CheckBox[] { ckbFragil, ckbPerisabil, ckbLivrareRapida, ckbAsigurareColet, ckbLivrareSambata, ckbLivrareDuminica },
                LabelEroareDimensiune = mlblEroareDimensiune,
                RadioButtons = new RadioButton[] { rdbMic, rdbMediuMic, rdbMediuStandard, rdbMediuMare, rdbMareMica, rdbMareStandard, rdbMareMare, rdbExtraMare }
            };

            bool areEroriPrevalidare = FormValidator.Prevalidare(controale);
            bool areEroriValidare = FormValidator.Validare(controale);

            if (areEroriPrevalidare || areEroriValidare)
            {
                return;
            }

            int idComanda = Int32.Parse(mlblIDComanda.Text);
            string numeClient = mtxtNumeClient.Text;
            string adresaLivrare = mtxtAdresaLivrare.Text;
            DateTime dataLivrare = dtpDataLivrare.Value;

            StareComanda stareComanda = (StareComanda)mCmbStareComanda.SelectedItem;

            int idColet = Int32.Parse(mlblIDColet.Text);
            string descriere = mtxtDescriere.Text;
            double greutate = double.Parse(nUDGreutate.Text);

            ArrayList OptiuniLivrare = new ArrayList();

            if (optiuniSelectate.Count == 0)
            {
                OptiuniLivrare.Add("None");
            }
            else
            {
                OptiuniLivrare.AddRange(optiuniSelectate);
            }

            DimensiuneColet dimensiuneSelectata = GetDimensiuneColetSelectat();

            Comanda comanda = new Comanda(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, OptiuniLivrare, idColet);
            Colet colet = new Colet(idColet, descriere, greutate, dimensiuneSelectata);

            gestiuneComenzi.UpdateComanda(comanda);
            gestiuneColete.UpdateColet(colet);

            Close();
        }

        private void btnModifica_MouseEnter(object sender, EventArgs e)
        {
            btnModifica.BackColor = Color.FromArgb(65, 111, 139);

        }
        private void btnModifica_MouseLeave(object sender, EventArgs e)
        {
            btnModifica.BackColor = Color.FromArgb(42, 71, 89);

        }
    }
}
