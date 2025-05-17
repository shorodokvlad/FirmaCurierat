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
using System.Configuration;
using System.IO;

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormaModificare : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;
        
        ArrayList optiuniSelectate = new ArrayList();
        
        private const int NR_MAX_CARACTERE = 50;


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

        public bool Prevalidare()
        {
            bool areErori = false;

            var campuriDeValidat = new (MetroTextBox TextBox, MetroLabel LabelEroare)[]
            {
                (mtxtNumeClient, mlblEroareNumeClient),
                (mtxtAdresaLivrare, mlblEroareAdresaLivrare),
                (mtxtDescriere, mlblEroareDescriere)
            };

            foreach (var (textBox, labelEroare) in campuriDeValidat)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    labelEroare.Text = "Campul nu poate fi gol!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    labelEroare.Text = string.Empty;
                }
            }

            if (decimal.TryParse(nUDGreutate.Text, out decimal greutate))
            {
                if (greutate < 0.01m)
                {
                    mlblEroareGreutate.Text = "Valoarea nu poate fi 0!";
                    mlblEroareGreutate.ForeColor = Color.Red;
                    areErori = true;
                }
                else
                {
                    mlblEroareGreutate.Text = string.Empty;
                }
            }
            else
            {
                mlblEroareGreutate.Text = "Campul nu poate fi gol!";
                mlblEroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            var checkBoxes = new CheckBox[] { ckbNone, ckbFragil, ckbFragil, ckbLivrareRapida, ckbAsigurareColet, ckbLivrareSambata, ckbLivrareDuminica };
            if (!checkBoxes.Any(cb => cb.Checked))
            {
                mlblEroareOptiuniLivrare.Text = "Trebuie să selectați cel puțin o opțiune de livrare!";
                mlblEroareOptiuniLivrare.ForeColor = Color.Red;
                areErori = true;
            }
            else
            {
                mlblEroareOptiuniLivrare.Text = string.Empty;
            }

            var radioButtons = new RadioButton[] { rdbMic, rdbMediuMic, rdbMediuStandard, rdbMediuMare, rdbMareMica, rdbMareStandard, rdbMareMare, rdbExtraMare };
            if (!radioButtons.Any(rb => rb.Checked))
            {
                mlblEroareDimensiune.Text = "Trebuie să selectați o dimensiune pentru colet!";
                mlblEroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }
            else
            {
                mlblEroareDimensiune.Text = string.Empty;
            }

            return areErori;
        }


        public bool Validare()
        {
            bool areErori = false;

            var campuriDeValidat = new (MetroTextBox TextBox, MetroLabel LabelEroare)[]
            {
                (mtxtNumeClient, mlblEroareNumeClient),
                (mtxtAdresaLivrare, mlblEroareAdresaLivrare),
                (mtxtDescriere, mlblEroareDescriere)
            };

            foreach (var (textBox, labelEroare) in campuriDeValidat)
            {
                if (textBox.Text.Length > NR_MAX_CARACTERE)
                {
                    labelEroare.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }

            }

            return areErori;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            bool areEroriPrevalidare = Prevalidare();

            bool areEroriValidare = Validare();

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
            OptiuniLivrare.AddRange(optiuniSelectate);

            DimensiuneColet dimensiuneSelectata = GetDimensiuneColetSelectat();

            Comanda comanda = new Comanda(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, OptiuniLivrare, idColet);
            Colet colet = new Colet(idColet, descriere, greutate, dimensiuneSelectata);

            gestiuneComenzi.UpdateComanda(comanda);
            gestiuneColete.UpdateColet(colet);

            this.Close();
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
