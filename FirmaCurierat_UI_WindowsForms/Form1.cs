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
    public partial class Form1 : MetroForm
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        public Form1()
        {
            InitializeComponent();

            string numeFisierComenzi = ConfigurationManager.AppSettings["NumeFisierComenzi"];
            string numeFisierColete = ConfigurationManager.AppSettings["NumeFisierColete"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierComenzi = locatieFisierSolutie + "\\" + numeFisierComenzi;
            string caleCompletaFisierColete = locatieFisierSolutie + "\\" + numeFisierColete;

            gestiuneComenzi = new GestionareComenzi_FisierText(caleCompletaFisierComenzi);
            gestiuneColete = new GestionareColete_FisierText(caleCompletaFisierColete);

            this.Load += new EventHandler(Form1_Load);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Comanda> comenzi = gestiuneComenzi.GetComenzi();
            List<Colet> colete = gestiuneColete.GetColete();

            AfiseazaComenziSiColeteInControlDataViewGrid(comenzi, colete);

        }

       
        private void AfiseazaComenziSiColeteInControlDataViewGrid(List<Comanda> comenzi, List<Colet> colete)
        {
            dataGridComenziSiColete.DataSource = null;

            if (comenzi.Count == 0)
            {
                MessageBox.Show("Nu exista comenzi in fisier!");
                return;
            }

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID Comanda");
            dataTable.Columns.Add("Nume Client");
            dataTable.Columns.Add("Aresa Livrare");
            dataTable.Columns.Add("Data Livrare");
            dataTable.Columns.Add("Stare Comanda");
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
                row["Aresa Livrare"] = comanda.AdresaLivrare;
                row["Data Livrare"] = comanda.DataLivrare.ToString();
                row["Stare Comanda"] = comanda.GetStareComandaText();

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
                    row["Greutate Colet"] = "N/A";
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


        private void mTileAdauga_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void mTileActualizeazaLista_Click(object sender, EventArgs e)
        {
            List<Comanda> comenzi = gestiuneComenzi.GetComenzi();
            List<Colet> colete = gestiuneColete.GetColete();
            AfiseazaComenziSiColeteInControlDataViewGrid(comenzi, colete);
        }

        private void mTileCautare_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}