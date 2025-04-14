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

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class Form1 : Form
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 40;
        private const int DIMENSIUNE_PAS_X = 160;

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


            // setare proprietati
            this.Size = new Size(1000, 500);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LightSlateGray;
            this.Text = "Informatii comnzi si colete";
           
            this.Load += new EventHandler(Form1_Load);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaComenziSiColete();
        }

        private void AfiseazaComenziSiColete()
        {
            List<Comanda> comenzi = gestiuneComenzi.GetComenzi();
            List<Colet> colete = gestiuneColete.GetColete();
            int nrComenzi = comenzi.Count;
            int nrColete = colete.Count;

            Label[,] lblsComenzi = new Label[nrComenzi, 5];
            Label[,] lblsColete = new Label[nrColete, 4];

            int i = 0;
            foreach (Comanda comanda in comenzi)
            {
                //adaugare control de tip Label pentru id-ul comenzii;
                lblsComenzi[i, 0] = new Label();
                lblsComenzi[i, 0].Width = LATIME_CONTROL;
                lblsComenzi[i, 0].Text = comanda.IDComanda.ToString();
                lblsComenzi[i, 0].Left = DIMENSIUNE_PAS_X;
                lblsComenzi[i, 0].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 0]);

                //adaugare control de tip Label pentru numele clientului
                lblsComenzi[i, 1] = new Label();
                lblsComenzi[i, 1].Width = LATIME_CONTROL;
                lblsComenzi[i, 1].Text = comanda.NumeClient;
                lblsComenzi[i, 1].Left = 2 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 1].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 1]);

                //adaugare control de tip Label pentru adresa livrarii
                lblsComenzi[i, 2] = new Label();
                lblsComenzi[i, 2].Width = LATIME_CONTROL;
                lblsComenzi[i, 2].Text = comanda.AdresaLivrare;
                lblsComenzi[i, 2].Left = 3 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 2].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 2]);

                //adaugare control de tip Label pentru data livrarii
                lblsComenzi[i, 3] = new Label();
                lblsComenzi[i, 3].Width = LATIME_CONTROL;
                lblsComenzi[i, 3].Text = comanda.DataLivrare.ToString();
                lblsComenzi[i, 3].Left = 4 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 3].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 3]);

                //adaugare control de tip Label pentru starea comenzii
                lblsComenzi[i, 4] = new Label();
                lblsComenzi[i, 4].Width = LATIME_CONTROL;
                lblsComenzi[i, 4].Text = comanda.GetStareComandaText();
                lblsComenzi[i, 4].Left = 5 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 4].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 4]);
                i++;
            }

            int j = 0;
            foreach (Colet colet in colete)
            {
                //adaugare control de tip Label pentru id-ul coletului;
                lblsColete[j, 0] = new Label();
                lblsColete[j, 0].Width = LATIME_CONTROL;
                lblsColete[j, 0].Text = colet.IDColet.ToString();
                lblsColete[j, 0].Left = 6 * DIMENSIUNE_PAS_X;
                lblsColete[j, 0].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 0]);

                //adaugare control de tip Label pentru descrierea coletului
                lblsColete[j, 1] = new Label();
                lblsColete[j, 1].Width = LATIME_CONTROL;
                lblsColete[j, 1].Text = colet.Descriere;
                lblsColete[j, 1].Left = 7 * DIMENSIUNE_PAS_X;
                lblsColete[j, 1].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 1]);

                //adaugare control de tip Label pentru greutatea coletului
                lblsColete[j, 2] = new Label();
                lblsColete[j, 2].Width = LATIME_CONTROL;
                lblsColete[j, 2].Text = colet.Greutate.ToString();
                lblsColete[j, 2].Left = 8 * DIMENSIUNE_PAS_X;
                lblsColete[j, 2].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 2]);

                //adaugare control de tip Label pentru dimensiunea coletului
                lblsColete[j, 3] = new Label();
                lblsColete[j, 3].Width = LATIME_CONTROL;
                lblsColete[j, 3].Text = colet.GetDimensiuneText();
                lblsColete[j, 3].Left = 9 * DIMENSIUNE_PAS_X;
                lblsColete[j, 3].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 3]);
                j++;
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            AfiseazaComenziSiColete();
        }

        private void buttoCautare_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}