using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Collections;


namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormAdaugare : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        ArrayList optiuniSelectate = new ArrayList();

        public FormAdaugare()
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
        }

        private void btnAdauga_Click(object sender, EventArgs e)
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

            int idComanda = gestiuneComenzi.GetId();
            string numeClient = mtxtNumeClient.Text;
            string adresaLivrare = mtxtAdresaLivrare.Text;
            DateTime dataLivrare = dtpDataLivrare.Value;

            StareComanda stareComanda = (StareComanda)mCmbStareComanda.SelectedItem;

            int idColet = gestiuneColete.GetId();
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

            gestiuneColete.AddColet(colet);
            gestiuneComenzi.AddComanda(comanda);

            ResetareControale();
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

        private void ResetareControale()
        {
            mtxtNumeClient.Text = mtxtAdresaLivrare.Text = mtxtDescriere.Text = string.Empty;
            ckbFragil.Checked = ckbPerisabil.Checked = ckbLivrareRapida.Checked = ckbAsigurareColet.Checked = ckbLivrareSambata.Checked = ckbLivrareDuminica.Checked = false;
            rdbMic.Checked = rdbMediuMic.Checked = rdbMediuStandard.Checked = rdbMediuMare.Checked = rdbMareMica.Checked = rdbMareStandard.Checked = rdbMareMare.Checked = false;
            dtpDataLivrare.Value = DateTime.Now;
            nUDGreutate.Value = 0.00m;
            mCmbStareComanda.SelectedIndex = 0;

        }

        private void btnAdauga_MouseEnter(object sender, EventArgs e)
        {
            btnSalveaza.BackColor = Color.FromArgb(65, 111, 139);
        }

        private void btnAdauga_MouseLeave(object sender, EventArgs e)
        {
            btnSalveaza.BackColor = Color.FromArgb(42, 71, 89);
        }
    }
}
