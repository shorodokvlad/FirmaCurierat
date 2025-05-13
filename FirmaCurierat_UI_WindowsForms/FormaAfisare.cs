using System;
using LibrarieModele;
using NivelStocareDate;
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
using System.Text.RegularExpressions;
using MetroFramework.Forms;
using MetroFramework.Controls;


namespace FirmaCurierat_UI_WindowsForms
{
    public partial class FormaAfisare : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        public FormaAfisare()
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

        private void AfisareComenziSiColete(List<Comanda> comenzi, List<Colet> colete)
        {
            dataGridComenziSiColete.DataSource = null;

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID Comanda");
            dataTable.Columns.Add("Nume Client");
            dataTable.Columns.Add("Adresa Livrare");
            dataTable.Columns.Add("Data Livrare");
            dataTable.Columns.Add("Stare Comanda");
            dataTable.Columns.Add("Optiuni Livrare");
            dataTable.Columns.Add("ID Colet");
            dataTable.Columns.Add("Descriere Colet");
            dataTable.Columns.Add("Greutate Colet [kg]");
            dataTable.Columns.Add("Dimensiune Colet");

            foreach (Comanda comanda in comenzi)
            {
                Colet colet = colete.FirstOrDefault(c => c.IDColet == comanda.IDColet);

                DataRow row = dataTable.NewRow();
                row["ID Comanda"] = comanda.IDComanda.ToString();
                row["Nume Client"] = comanda.NumeClient;
                row["Adresa Livrare"] = comanda.AdresaLivrare;
                row["Data Livrare"] = comanda.DataLivrare.ToString();
                row["Stare Comanda"] = comanda.StareComandaToString();
                row["Optiuni Livrare"] = comanda.OptiuniLivrareToString();

                if (colet != null)
                {
                    row["ID Colet"] = colet.IDColet.ToString();
                    row["Descriere Colet"] = colet.Descriere;
                    row["Greutate Colet [kg]"] = colet.Greutate.ToString();
                    row["Dimensiune Colet"] = colet.GetDimensiuneText();
                }
                else
                {
                    row["ID Colet"] = "N/A";
                    row["Descriere Colet"] = "N/A";
                    row["Greutate Colet [kg]"] = "N/A";
                    row["Dimensiune Colet"] = "N/A";
                }

                dataTable.Rows.Add(row);
            }

            dataGridComenziSiColete.DataSource = dataTable;

            dataGridComenziSiColete.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dataGridComenziSiColete.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridComenziSiColete.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dataGridComenziSiColete.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dataGridComenziSiColete.EnableHeadersVisualStyles = false;
        }


        private void mtAdauga_Click(object sender, EventArgs e)
        {
            FormAdaugare form2 = new FormAdaugare();
            form2.Show();
        }

        private void mtActualizeazaLista_Click(object sender, EventArgs e)
        {
            List<Comanda> comenzi = gestiuneComenzi.GetComenzi();
            List<Colet> colete = gestiuneColete.GetColete();
            AfisareComenziSiColete(comenzi, colete);
        }

        private void mtCautare_Click(object sender, EventArgs e)
        {
            FormaCautareComanda form3 = new FormaCautareComanda();
            form3.Show();
        }

        private void mtCautaColet_Click(object sender, EventArgs e)
        {
            FormCautareColet form4 = new FormCautareColet();
            form4.Show();
        }

        private void mtModifica_Click(object sender, EventArgs e)
        { 
            if (dataGridComenziSiColete.CurrentRow == null)
            {
                MessageBox.Show("Selectati o comanda pentru a o modifica.");
                return;
            }

            FormaModificare form5 = new FormaModificare(Convert.ToInt32(dataGridComenziSiColete.CurrentRow.Cells[0].Value));
            form5.ShowDialog();
        }
    }
}