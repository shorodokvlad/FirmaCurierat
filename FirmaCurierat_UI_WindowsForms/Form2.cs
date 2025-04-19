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


namespace FirmaCurierat_UI_WindowsForms
{
    public partial class Form2: MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        private const int NR_MAX_CARACTERE = 50;
        public Form2()
        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);
            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);

        }
        private void ClearTextBoxes()
        {
            var textBoxes = new MetroTextBox[] { txtNumeClient, txtAdresaLivrare, txtDataLivrare, txtStareComanda, txtDescriere, txtGreutate, txtDimensiune };

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
        }

        public bool Prevalidare()
        {
            bool areErori = false;

            var campuriDeValidat = new (MetroTextBox TextBox, MetroLabel LabelEroare)[]
            {
                (txtNumeClient, txtEroareNumeClient),
                (txtAdresaLivrare, txtEroareAdresaLivrare),
                (txtDataLivrare, txtEroareDataLivrare),
                (txtStareComanda, txtEroareStareComanda),
                (txtDescriere, txtEroareDescriere),
                (txtGreutate, txtEroareGreutate),
                (txtDimensiune, txtEroareDimensiune)
            };

            foreach (var (textBox, labelEroare) in campuriDeValidat)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    labelEroare.Text = "Nu poate fi gol!";
                    labelEroare.ForeColor = Color.Red;
                    areErori = true;
                }
            }

            return areErori;
        }


        public bool Validare()
        {
            bool areErori = false;

            var campuriDeValidat = new (MetroTextBox TextBox, MetroLabel LabelEroare)[]
            {
                (txtNumeClient, txtEroareNumeClient),
                (txtAdresaLivrare, txtEroareAdresaLivrare),
                (txtDataLivrare, txtEroareDataLivrare),
                (txtDescriere, txtEroareDescriere)
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

            // Validare specifică pentru alte câmpuri
            if (!string.IsNullOrWhiteSpace(txtGreutate.Text) && !double.TryParse(txtGreutate.Text, out _))
            {
                txtEroareGreutate.Text = "Trebuie sa fie un numar!";
                txtEroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            if (!string.IsNullOrWhiteSpace(txtStareComanda.Text) && !Enum.TryParse<StareComanda>(txtStareComanda.Text, out _))
            {
                txtEroareStareComanda.Text = "Valoarea nu este validă!";
                txtEroareStareComanda.ForeColor = Color.Red;
                areErori = true;
            }

            if (!string.IsNullOrWhiteSpace(txtDimensiune.Text) && !Enum.TryParse<DimensiuneColet>(txtDimensiune.Text, out _))
            {
                txtEroareDimensiune.Text = "Valoarea nu este validă!";
                txtEroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }

            return areErori;
        }

        private void mtSalveaza_Click(object sender, EventArgs e)
        {
            // Resetăm mesajele de eroare
            txtEroareNumeClient.Text = "";
            txtEroareAdresaLivrare.Text = "";
            txtEroareDataLivrare.Text = "";
            txtEroareStareComanda.Text = "";
            txtEroareDescriere.Text = "";
            txtEroareGreutate.Text = "";
            txtEroareDimensiune.Text = "";


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
            string numeClient = txtNumeClient.Text;
            string adresaLivrare = txtAdresaLivrare.Text;
            string dataLivrare = txtDataLivrare.Text;
            StareComanda stareComanda = (StareComanda)Enum.Parse(typeof(StareComanda), txtStareComanda.Text);
            int idColet = gestiuneColete.GetId();
            string descriere = txtDescriere.Text;
            double greutate = double.Parse(txtGreutate.Text);
            DimensiuneColet dimensiune = (DimensiuneColet)Enum.Parse(typeof(DimensiuneColet), txtDimensiune.Text);

            Colet colet = new Colet(idColet, descriere, greutate, dimensiune);
            Comanda comanda = new Comanda(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, colet, idColet);

            gestiuneColete.AddColet(colet);
            gestiuneComenzi.AddComanda(comanda);

            MessageBox.Show("Comanda a fost adaugata cu succes!");

            ClearTextBoxes();
        }
    }
}
