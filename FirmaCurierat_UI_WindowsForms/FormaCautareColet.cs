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

        private const int NR_MAX_CARACTERE = 50;
        public FormCautareColet()
        {
            InitializeComponent();

            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);
        }
        public string DescriereCautata { get; set; }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string descriere = mtxtDescriere.Text;

            if (string.IsNullOrWhiteSpace(descriere))
            {
                mlblEroareDescriere.Text = "Nu poate fi gol!";
                return;
            }

            if (descriere.Length > NR_MAX_CARACTERE)
            {
                mlblEroareDescriere.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                return;
            }

            mlblEroareDescriere.Text = string.Empty;

            List<Colet> coleteGasite = gestiuneColete.GetColete(descriere);
            if (coleteGasite.Count > 0)
            {
                DescriereCautata = mtxtDescriere.Text;
                Close();
            }
            else
            {
                mtxtDescriere.Text = string.Empty;
                MessageBox.Show("Nu a fost gasit niciun colet cu descrierea specificata.");
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
