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
            dataTable.Columns.Add("Greutate Colet");
            dataTable.Columns.Add("Dimensiune Colet");

            foreach (Comanda comanda in comenzi)
            {
                Colet colet = colete.FirstOrDefault(c => c.IDColet == comanda.IDColet);

                DataRow row = dataTable.NewRow();
                row["ID Comanda"] = comanda.IDComanda.ToString();
                row["Nume Client"] = comanda.NumeClient;
                row["Adresa Livrare"] = comanda.AdresaLivrare;
                row["Data Livrare"] = comanda.DataLivrare.ToString("dd/MM/yyyy"); 
                row["Stare Comanda"] = comanda.StareComandaToString();
                row["Optiuni Livrare"] = comanda.OptiuniLivrareToString();

                if (colet != null)
                {
                    row["ID Colet"] = colet.IDColet.ToString();
                    row["Descriere Colet"] = colet.Descriere;
                    row["Greutate Colet"] = colet.Greutate + " kg";
                    row["Dimensiune Colet"] = colet.DimensiuneToString();
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

            for (int i = 0; i < dataGridComenziSiColete.SelectedRows.Count; i++)
            {
                dataGridComenziSiColete.SelectedRows[i].Selected = false;
            }

            dataGridComenziSiColete.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridComenziSiColete.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10);
            
        }

        private void ActualizareDataGrid()
        {
            dataGridComenziSiColete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            List<Comanda> comenzi = gestiuneComenzi.GetComenzi();
            List<Colet> colete = gestiuneColete.GetColete();
            AfisareComenziSiColete(comenzi, colete);
        }
        private void FormaAfisare_Load(object sender, EventArgs e)
        {
            ActualizareDataGrid();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            FormAdaugare form2 = new FormAdaugare();
            form2.ShowDialog();

            ActualizareDataGrid();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            ActualizareDataGrid();
        }
        private void btnCautaComanda_Click(object sender, EventArgs e)
        {
            FormaCautareComanda form3 = new FormaCautareComanda();
            form3.ShowDialog();

            string numeClient = form3.NumeClient;

            if (!string.IsNullOrEmpty(numeClient))
            {
                List<Comanda> comenzi = gestiuneComenzi.GetComenzi(numeClient);
                List<Colet> colete = gestiuneColete.GetColete().Where(c => comenzi.Any(comanda => comanda.IDColet == c.IDColet)).ToList();

                dataGridComenziSiColete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AfisareComenziSiColete(comenzi, colete);
            }
        }

        private void btnCautaColet_Click(object sender, EventArgs e)
        {
            FormCautareColet form4 = new FormCautareColet();
            form4.ShowDialog();

            string descriere = form4.DescriereCautata;
            if (!string.IsNullOrEmpty(descriere))
            {
                List<Colet> colete = gestiuneColete.GetColete(descriere);
                List<Comanda> comenzi = gestiuneComenzi.GetComenzi().Where(c => colete.Any(colet => colet.IDColet == c.IDColet)).ToList();

                dataGridComenziSiColete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                AfisareComenziSiColete(comenzi, colete);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            if (dataGridComenziSiColete.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda pentru a o modifica.");
                return;
            }

            int idComanda = Convert.ToInt32(dataGridComenziSiColete.SelectedRows[0].Cells[0].Value);

            FormaModificare form5 = new FormaModificare(idComanda);
            form5.ShowDialog();

            ActualizareDataGrid();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dataGridComenziSiColete.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati o comanda pentru a o sterge.");
                return;
            }

            int idComanda = Convert.ToInt32(dataGridComenziSiColete.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("Sigur doriti sa stergeti aceasta comanda?", "Confirmare stergere", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            Comanda comanda = gestiuneComenzi.GetComanda(idComanda);
            bool rezultatStergereComanda = false;
            bool rezultatStergereColet = false;

            if (comanda != null)
            {
                rezultatStergereComanda = gestiuneComenzi.DeleteComanda(idComanda);
                rezultatStergereColet = gestiuneColete.DeleteColet(comanda.IDColet);
            }

            if (rezultatStergereComanda)
            {
                ActualizareDataGrid();
            }
            else
            {
                MessageBox.Show("Nu s-a putut sterge comanda.");
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(65, 111, 139);
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(42, 71, 89);
            }
        }
    }
}