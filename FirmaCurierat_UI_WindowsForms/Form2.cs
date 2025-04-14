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

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class Form2: Form
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        private int NR_MAX_CARACTERE = 20;
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

            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LightSlateGray;
            this.Text = "Adaugare comnzi si colete";
        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            // Resetăm mesajele de eroare
            eroareNumeClient.Text = "";
            eroareAdresaLivrare.Text = "";
            eroareDataLivrare.Text = "";
            eroareStareComanda.Text = "";
            eroareDescriere.Text = "";
            eroareGreutate.Text = "";
            eroareDimensiune.Text = "";

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

            MessageBox.Show("Comanda si coletul au fost adaugate cu succes!");

            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        public bool Prevalidare()
        {
            bool areErori = false;

            if (string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                eroareNumeClient.Text = "Nu poate fi gol!";
                eroareNumeClient.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtAdresaLivrare.Text))
            {
                eroareAdresaLivrare.Text = "Nu poate fi gol!";
                eroareAdresaLivrare.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtDataLivrare.Text))
            {
                eroareDataLivrare.Text = "Nu poate fi gol!";
                eroareDataLivrare.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtStareComanda.Text))
            {
                eroareStareComanda.Text = "Nu poate fi gol!";
                eroareStareComanda.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                eroareDescriere.Text = "Nu poate fi gol!";
                eroareDescriere.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtGreutate.Text))
            {
                eroareGreutate.Text = "Nu poate fi gol!";
                eroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            if (string.IsNullOrWhiteSpace(txtDimensiune.Text))
            {
                eroareDimensiune.Text = "Nu poate fi gol!";
                eroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }

            return areErori;
        }


        public bool Validare()
        {
            bool areErori = false;


            if (!string.IsNullOrWhiteSpace(txtGreutate.Text) && !double.TryParse(txtGreutate.Text, out _))
            {
                eroareGreutate.Text = "Trebuie sa fie un numar!";
                eroareGreutate.ForeColor = Color.Red;
                areErori = true;
            }

            if (!string.IsNullOrWhiteSpace(txtStareComanda.Text) && !Enum.TryParse<StareComanda>(txtStareComanda.Text, out _))
            {
                eroareStareComanda.Text = "Valoarea nu este validă!";
                eroareStareComanda.ForeColor = Color.Red;
                areErori = true;
            }

            if (!string.IsNullOrWhiteSpace(txtDimensiune.Text) && !Enum.TryParse<DimensiuneColet>(txtDimensiune.Text, out _))
            {
                eroareDimensiune.Text = "Valoarea nu este validă!";
                eroareDimensiune.ForeColor = Color.Red;
                areErori = true;
            }

            if (txtNumeClient.Text.Length > NR_MAX_CARACTERE)
            {
                eroareNumeClient.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                eroareNumeClient.ForeColor = Color.Red;
                areErori = true;
            }

            if (txtAdresaLivrare.Text.Length > NR_MAX_CARACTERE)
            {
                eroareAdresaLivrare.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                eroareAdresaLivrare.ForeColor = Color.Red;
                areErori = true;
            }

            if (txtDataLivrare.Text.Length > NR_MAX_CARACTERE)
            {
                eroareDataLivrare.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                eroareDataLivrare.ForeColor = Color.Red;
                areErori = true;
            }

            if (txtDescriere.Text.Length > NR_MAX_CARACTERE)
            {
                eroareDescriere.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                eroareDescriere.ForeColor = Color.Red;
                areErori = true;
            }

            return areErori;
        }
    }
}
