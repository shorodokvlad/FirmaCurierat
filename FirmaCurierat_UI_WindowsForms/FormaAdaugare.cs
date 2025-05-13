using LibrarieModele;
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

        private const int NR_MAX_CARACTERE = 50;

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

        public bool Prevalidare()
        {
            bool areErori = false;

            var campuriDeValidat = new (MetroTextBox TextBox, MetroLabel LabelEroare)[]
            {
                (mtxtNumeClient, mlblEroareNumeClient),
                (mtxtAdresaLivrare, mlblEroareAdresaLivrare),
                (mtxtDataLivrare, mlblEroareDataLivrare),
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

            // Validare pentru checkbox-uri (optiuni livrare)
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

            // Validare pentru radio butoane (dimensiune colet)
            var radioButtons = new RadioButton[] { rdbMic, rdbMediuMic, rdbMediuStandard, rdbMediuMare, rdbMareMica, rdbMareStandard, rdbMareMare };
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
                (mtxtDataLivrare, mlblEroareDataLivrare),
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

        // Updated code to read StareComanda from the combo box
        private void mtSalveaza_Click(object sender, EventArgs e)
        {
            // Verificăm câmpurile goale
            bool areEroriPrevalidare = Prevalidare();

            // Verificăm validitatea datelor
            bool areEroriValidare = Validare();

            // Dacă există erori în oricare dintre metode, nu continuăm
            if (areEroriPrevalidare || areEroriValidare)
            {
                return;
            }

            // Dacă nu există erori, adăugăm comanda și coletul
            int idComanda = gestiuneComenzi.GetId();
            string numeClient = mtxtNumeClient.Text;
            string adresaLivrare = mtxtAdresaLivrare.Text;
            string dataLivrare = mtxtDataLivrare.Text;

            // Read StareComanda from the combo box
            StareComanda stareComanda = (StareComanda)mCmbStareComanda.SelectedItem;

            int idColet = gestiuneColete.GetId();
            string descriere = mtxtDescriere.Text;
            double greutate = double.Parse(nUDGreutate.Text);

            ArrayList OptiuniLivrare = new ArrayList();
            OptiuniLivrare.AddRange(optiuniSelectate);

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

        private void ResetareControale()
        {
            var textBoxes = new MetroTextBox[] { mtxtNumeClient, mtxtAdresaLivrare, mtxtDataLivrare, mtxtDescriere };

            foreach (var textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }

            var checkBoxes = new CheckBox[] { ckbNone, ckbFragil, ckbFragil, ckbLivrareRapida, ckbAsigurareColet, ckbLivrareSambata, ckbLivrareDuminica };
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }

            var radioButtons = new RadioButton[] { rdbMic, rdbMediuMic, rdbMediuStandard, rdbMediuMare, rdbMareMica, rdbMareStandard, rdbMareMare };
            foreach (var radioButton in radioButtons)
            {
                radioButton.Checked = false;
            }

            nUDGreutate.Value = 0.00m;
            mCmbStareComanda.SelectedIndex = -1;

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
    }
}
