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
using MetroFramework;
using MetroFramework.Controls;





namespace FirmaCurierat_UI_WindowsForms
{
    public partial class Form3 : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;
        public Form3()

        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);
            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);

        }


        private void buttonCautaComanda_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIDComanda.Text) && int.TryParse(txtIDComanda.Text, out int idComanda))
            {
                Comanda comandaGasita = gestiuneComenzi.GetComanda(idComanda);

                if (comandaGasita != null)
                {
                    MessageBox.Show(comandaGasita.Info(), "Comanda gasita");
                }
                else
                {
                    MessageBox.Show($"Comanda cu ID-ul #{txtIDComanda.Text} nu a fost gasita.");
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                Comanda comandaGasita = gestiuneComenzi.GetComanda(txtNumeClient.Text);

                if (comandaGasita != null)
                {
                    MessageBox.Show(comandaGasita.Info(), "Comanda gasita");
                }
                else
                {
                    MessageBox.Show($"Comanda cu numele clientului {txtNumeClient.Text} nu a fost gasita.");
                }
            }
            else
            {
                MessageBox.Show("Introduceți un ID valid sau un nume de client.");
            }
        }



        private void buttonCautaColet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIDColet.Text) && int.TryParse(txtIDColet.Text, out int idColet))
            {
                Colet coletGasit = gestiuneColete.GetColet(idColet);

                if (coletGasit != null)
                {
                    MessageBox.Show(coletGasit.Info(), "Colet gasit");
                }
                else
                {
                    MessageBox.Show($"Coletul cu ID-ul #{txtIDColet.Text} nu a fost gasit.");
                }
            }
            else if (!string.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                Colet coletGasit = gestiuneColete.GetColet(txtDescriere.Text);

                if (coletGasit != null)
                {

                    MessageBox.Show(coletGasit.Info(), "Colet gasit");
                }
                else
                {
                    MessageBox.Show("Coletul cu descrierea specificata nu a fost gasit.");
                }
            }
            else
            {
                MessageBox.Show("Introduceti un ID valid sau o descriere.");
            }
        }

    }
}
