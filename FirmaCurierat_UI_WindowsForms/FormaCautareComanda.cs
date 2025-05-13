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

        private const int NR_MAX_CARACTERE = 30;
        public FormaCautareComanda()

        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);

        }

        private void mtCautaDupaIDComanda_Click(object sender, EventArgs e)
        {
            string idText = mtxtIDComanda.Text;

            // Verificare dacă este gol
            if (string.IsNullOrWhiteSpace(idText))
            {
                mlblEroareIDComanda.Text = "Nu poate fi gol!";
                return;
            }

            // Verificare dacă este un număr
            if (!int.TryParse(idText, out int idComanda))
            {
                mlblEroareIDComanda.Text = "Trebuie să fie un număr!";
                return;
            }

            // Dacă este valid, ascundem mesajul de eroare
            mlblEroareIDComanda.Text = string.Empty;

            // Căutare colet
            Comanda comandaGasita = gestiuneComenzi.GetComanda(idComanda);

            if (comandaGasita != null)
            {
                MessageBox.Show(comandaGasita.Info(), "Comanda găsita");
            }
            else
            {
                MessageBox.Show($"Comanda cu ID-ul #{mtxtIDComanda.Text} nu a fost gasita.");
            }
        }

        private void mtCautaDupaNumeClient_Click(object sender, EventArgs e)
        {
            string numeClient = mtxtNumeClient.Text;

            // Verificare dacă este gol
            if (string.IsNullOrWhiteSpace(numeClient))
            {
                mlblEroareNumeClient.Text = "Nu poate fi gol!";
                return;
            }

            // Verificare dacă depășește 30 de caractere
            if (numeClient.Length > 30)
            {
                mlblEroareNumeClient.Text = $"Max. {NR_MAX_CARACTERE} caractere!";
                return;
            }

            // Dacă este valid, ascundem mesajul de eroare
            mlblEroareNumeClient.Text = string.Empty;

            // Căutare colet
            Comanda comandaGasita = gestiuneComenzi.GetComanda(numeClient);

            if (comandaGasita != null)
            {
                MessageBox.Show(comandaGasita.Info(), "Comanda găsita");
            }
            else
            {
                MessageBox.Show($"Comanda cu nume {numeClient} nu a fost gasita.");
            }
        }
    }
}
