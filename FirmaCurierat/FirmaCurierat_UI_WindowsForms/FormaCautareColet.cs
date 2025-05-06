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
using LibrarieModele;
using MetroFramework.Controls;
using MetroFramework.Forms;
using NivelStocareDate;

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormCautareColet: MetroForm
    {
        GestionareColete_FisierText gestiuneColete;

        private const int NR_MAX_CARACTERE = 30;
        public FormCautareColet()
        {
            InitializeComponent();

            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);
        }

        private void mtCautaDupaIDColet_Click(object sender, EventArgs e)
        {
            string idText = mtxtIDColet.Text;

            // Verificare dacă este gol
            if (string.IsNullOrWhiteSpace(idText))
            {
                mlblEroareIDColet.Text = "Nu poate fi gol!";
                return;
            }

            // Verificare dacă este un număr
            if (!int.TryParse(idText, out int idColet))
            {
                mlblEroareIDColet.Text = "Trebuie să fie un număr!";
                return;
            }

            // Dacă este valid, ascundem mesajul de eroare
            mlblEroareIDColet.Text = string.Empty;

            // Căutare colet
            Colet coletGasit = gestiuneColete.GetColet(idColet);

            if (coletGasit != null)
            {
                MessageBox.Show(coletGasit.Info(), "Colet găsit");
            }
            else
            {
                MessageBox.Show($"Coletul cu ID-ul #{idText} nu a fost găsit.");
            }

            ResetareControale();
        }

        private void mtCautaDupaDescriereColet_Click(object sender, EventArgs e)
        {
            string descriere = mtxtDescriere.Text;

            // Verificare dacă este gol
            if (string.IsNullOrWhiteSpace(descriere))
            {
                mlblEroareDescriere.Text = "Nu poate fi gol!";
                return;
            }

            // Verificare dacă depășește 30 de caractere
            if (descriere.Length > 30)
            {
                mlblEroareDescriere.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                return;
            }

            // Dacă este valid, ascundem mesajul de eroare
            mlblEroareDescriere.Text = string.Empty;

            // Căutare colet
            Colet coletGasit = gestiuneColete.GetColet(descriere);

            if (coletGasit != null)
            {
                MessageBox.Show(coletGasit.Info(), "Colet găsit");
            }
            else
            {
                MessageBox.Show("Coletul cu descrierea specificată nu a fost găsit.");
            }

            ResetareControale();
        }

        private void ResetareControale()
        {
            var textBoxes = new MetroTextBox[] { mtxtIDColet, mtxtDescriere };
            var mlblsEroare = new MetroLabel[] { mlblEroareIDColet, mlblEroareDescriere };

            foreach (var textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }

            foreach (var lblEroare in mlblsEroare)
            {
                lblEroare.Text = string.Empty;
            }

        }

    }
}
