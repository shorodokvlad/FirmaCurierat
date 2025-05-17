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
using LibrarieModele;
using MetroFramework.Forms;

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormaCautareComanda : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;

        private const int NR_MAX_CARACTERE = 50;
        public FormaCautareComanda()

        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);

        }
        public string NumeClient { get; set; }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string numeClient = mtxtNumeClient.Text;

            if (string.IsNullOrWhiteSpace(numeClient))
            {
                mlblEroareNumeClient.Text = "Nu poate fi gol!";
                return;
            }

            if (numeClient.Length > NR_MAX_CARACTERE)
            {
                mlblEroareNumeClient.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                return;
            }

            mlblEroareNumeClient.Text = string.Empty;

            List<Comanda> comenziGasite = gestiuneComenzi.GetComenzi(numeClient);
            if (comenziGasite.Count > 0)
            {
                NumeClient = mtxtNumeClient.Text;
                Close();
            }
            else
            {
                mtxtNumeClient.Text = string.Empty;
                MessageBox.Show("Nu a fost gasita nicio comanda cu numele specificat.");
            }
        }

        private void btnCauta_MouseEnter(object sender, EventArgs e)
        {
            btnCauta.BackColor = Color.FromArgb(65, 111, 139);
        }

        private void btnCauta_MouseLeave(object sender, EventArgs e)
        {
            btnCauta.BackColor = Color.FromArgb(42, 71, 89);

        }


    }
}
