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

namespace FirmaCurierat_UI_WindowsForms
{
    public partial class Form1 : Form
    {
        GestionareComenzi_FisierText gestiuneComenzi;
        GestionareColete_FisierText gestiuneColete;

        private Label lblIdComanda;
        private Label lblNumeClient;
        private Label lblAdresaLivrare;
        private Label lblDataLivrare;
        private Label lblStareComanda;
        private Label lblIdColet;
        private Label lblDescriere;
        private Label lblGreutate;
        private Label lblDimensiune;

        private Label[] lblsIdComanda;
        private Label[] lblsNumeClient;
        private Label[] lblsAdresaLivrare;
        private Label[] lblsDataLivrare;
        private Label[] lblsStareComanda;
        private Label[] lblsIdColet;
        private Label[] lblsDescriere;
        private Label[] lblsGreutate;
        private Label[] lblsDimensiune;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

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

            //setare proprietati
            this.Size = new Size(1000, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Coral;
            this.Text = "Informatii comenzi si colete";

            //adaugare control de tip Label pentru 'IdComanda';
            lblIdComanda = new Label();
            lblIdComanda.Width = LATIME_CONTROL;
            lblIdComanda.Text = "Id Comanda";
            lblIdComanda.Left = DIMENSIUNE_PAS_X;
            lblIdComanda.ForeColor = Color.Chocolate;
            this.Controls.Add(lblIdComanda);

            //adaugare control de tip Label pentru 'NumeClient';
            lblNumeClient = new Label();
            lblNumeClient.Width = LATIME_CONTROL;
            lblNumeClient.Text = "Nume Client";
            lblNumeClient.Left = 2 * DIMENSIUNE_PAS_X;
            lblNumeClient.ForeColor = Color.Chocolate;
            this.Controls.Add(lblNumeClient);

            //adaugare control de tip Label pentru 'AdresaLivrare';
            lblAdresaLivrare = new Label();
            lblAdresaLivrare.Width = LATIME_CONTROL;
            lblAdresaLivrare.Text = "Adresa Livrare";
            lblAdresaLivrare.Left = 3 * DIMENSIUNE_PAS_X;
            lblAdresaLivrare.ForeColor = Color.Chocolate;
            this.Controls.Add(lblAdresaLivrare);

            //adaugare control de tip Label pentru 'DataLivrare';
            lblDataLivrare = new Label();
            lblDataLivrare.Width = LATIME_CONTROL;
            lblDataLivrare.Text = "Data Livrare";
            lblDataLivrare.Left = 4 * DIMENSIUNE_PAS_X;
            lblDataLivrare.ForeColor = Color.Chocolate;
            this.Controls.Add(lblDataLivrare);

            //adaugare control de tip Label pentru 'StareComanda';
            lblStareComanda = new Label();
            lblStareComanda.Width = LATIME_CONTROL;
            lblStareComanda.Text = "Stare Comanda";
            lblStareComanda.Left = 5 * DIMENSIUNE_PAS_X;
            lblStareComanda.ForeColor = Color.Chocolate;
            this.Controls.Add(lblStareComanda);

            //adaugare control de tip Label pentru 'IdColet';
            lblIdColet = new Label();
            lblIdColet.Width = LATIME_CONTROL;
            lblIdColet.Text = "Id Colet";
            lblIdColet.Left = 6 * DIMENSIUNE_PAS_X;
            lblIdColet.ForeColor = Color.Chocolate;
            this.Controls.Add(lblIdColet);

            //adaugare control de tip Label pentru 'Descriere';
            lblDescriere = new Label();
            lblDescriere.Width = LATIME_CONTROL;
            lblDescriere.Text = "Descriere";
            lblDescriere.Left = 7 * DIMENSIUNE_PAS_X;
            lblDescriere.ForeColor = Color.Chocolate;
            this.Controls.Add(lblDescriere);

            //adaugare control de tip Label pentru 'Greutate';
            lblGreutate = new Label();
            lblGreutate.Width = LATIME_CONTROL;
            lblGreutate.Text = "Greutate";
            lblGreutate.Left = 8 * DIMENSIUNE_PAS_X;
            lblGreutate.ForeColor = Color.Chocolate;
            this.Controls.Add(lblGreutate);

            //adaugare control de tip Label pentru 'Dimensiune';
            lblDimensiune = new Label();
            lblDimensiune.Width = LATIME_CONTROL;
            lblDimensiune.Text = "Dimensiune";
            lblDimensiune.Left = 9 * DIMENSIUNE_PAS_X;
            lblDimensiune.ForeColor = Color.Chocolate;
            this.Controls.Add(lblDimensiune);

            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaComenziSiColete();
        }

        private void AfiseazaComenziSiColete()
        {
            Comanda[] comenzi = gestiuneComenzi.GetComenzi(out int nrComenzi);
            Colet[] colete = gestiuneColete.GetColete(out int nrColete);

            lblsIdComanda = new Label[nrComenzi];
            lblsNumeClient = new Label[nrComenzi];
            lblsAdresaLivrare = new Label[nrComenzi];
            lblsDataLivrare = new Label[nrComenzi];
            lblsStareComanda = new Label[nrComenzi];
            lblsIdColet = new Label[nrColete];
            lblsDescriere = new Label[nrColete];
            lblsGreutate = new Label[nrColete];
            lblsDimensiune = new Label[nrColete];

            int i = 0;
            foreach (Comanda comanda in comenzi)
            {
                //adaugare control de tip Label pentru id-ul comenzii;
                lblsIdComanda[i] = new Label();
                lblsIdComanda[i].Width = LATIME_CONTROL;
                lblsIdComanda[i].Text = comanda.IDComanda.ToString();
                lblsIdComanda[i].Left = DIMENSIUNE_PAS_X;
                lblsIdComanda[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsIdComanda[i]);

                //adaugare control de tip Label pentru numele clientului
                lblsNumeClient[i] = new Label();
                lblsNumeClient[i].Width = LATIME_CONTROL;
                lblsNumeClient[i].Text = comanda.NumeClient;
                lblsNumeClient[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsNumeClient[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNumeClient[i]);

                //adaugare control de tip Label pentru adresa livrarii
                lblsAdresaLivrare[i] = new Label();
                lblsAdresaLivrare[i].Width = LATIME_CONTROL;
                lblsAdresaLivrare[i].Text = comanda.AdresaLivrare;
                lblsAdresaLivrare[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsAdresaLivrare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAdresaLivrare[i]);

                //adaugare control de tip Label pentru data livrarii
                lblsDataLivrare[i] = new Label();
                lblsDataLivrare[i].Width = LATIME_CONTROL;
                lblsDataLivrare[i].Text = comanda.DataLivrare.ToString();
                lblsDataLivrare[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsDataLivrare[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDataLivrare[i]);

                //adaugare control de tip Label pentru starea comenzii
                lblsStareComanda[i] = new Label();
                lblsStareComanda[i].Width = LATIME_CONTROL;
                lblsStareComanda[i].Text = comanda.StareComanda.ToString();
                lblsStareComanda[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsStareComanda[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsStareComanda[i]);
                i++;
            }

            int j = 0;
            foreach (Colet colet in colete)
            {
                //adaugare control de tip Label pentru id-ul coletului;
                lblsIdColet[j] = new Label();
                lblsIdColet[j].Width = LATIME_CONTROL;
                lblsIdColet[j].Text = colet.IDColet.ToString();
                lblsIdColet[j].Left = 6 * DIMENSIUNE_PAS_X;
                lblsIdColet[j].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsIdColet[j]);

                //adaugare control de tip Label pentru descrierea coletului
                lblsDescriere[j] = new Label();
                lblsDescriere[j].Width = LATIME_CONTROL;
                lblsDescriere[j].Text = colet.Descriere;
                lblsDescriere[j].Left = 7 * DIMENSIUNE_PAS_X;
                lblsDescriere[j].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDescriere[j]);

                //adaugare control de tip Label pentru greutatea coletului
                lblsGreutate[j] = new Label();
                lblsGreutate[j].Width = LATIME_CONTROL;
                lblsGreutate[j].Text = colet.Greutate.ToString();
                lblsGreutate[j].Left = 8 * DIMENSIUNE_PAS_X;
                lblsGreutate[j].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsGreutate[j]);

                //adaugare control de tip Label pentru dimensiunea coletului
                lblsDimensiune[j] = new Label();
                lblsDimensiune[j].Width = LATIME_CONTROL;
                lblsDimensiune[j].Text = colet.Dimensiune;
                lblsDimensiune[j].Left = 9 * DIMENSIUNE_PAS_X;
                lblsDimensiune[j].Top = (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDimensiune[j]);
                j++;
            }
        }
    }
}
