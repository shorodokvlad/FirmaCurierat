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

        private int NR_MAX_CARACTERE = 20;

        private Label lblIdComanda;
        private Label lblNumeClient;
        private Label lblAdresaLivrare;
        private Label lblDataLivrare;
        private Label lblStareComanda;
        private Label lblIdColet;
        private Label lblDescriere;
        private Label lblGreutate;
        private Label lblDimensiune;

        private Label eroareIDComanda;
        private Label eroareNumeClient;
        private Label eroareAdresaLivrare;
        private Label eroareDataLivrare;
        private Label eroareStareComanda;
        private Label eroareIDColet;
        private Label eroareDescriere;
        private Label eroareGreutate;
        private Label eroareDimensiune;

        private TextBox txtIDComanda;
        private TextBox txtNumeClient;
        private TextBox txtAdresaLivrare;
        private TextBox txtDataLivrare;
        private TextBox txtStareComanda;
        private TextBox txtIDColet;
        private TextBox txtDescriere;
        private TextBox txtGreutate;
        private TextBox txtDimensiune;

        private Label[] lblsIdComanda;
        private Label[] lblsNumeClient;
        private Label[] lblsAdresaLivrare;
        private Label[] lblsDataLivrare;
        private Label[] lblsStareComanda;
        private Label[] lblsIdColet;
        private Label[] lblsDescriere;
        private Label[] lblsGreutate;
        private Label[] lblsDimensiune;

        private Button buttonAdauga;
        private Button buttonRefresh;

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

            //setare proprietati
            this.Size = new Size(1000, 400);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(0, 112, 116);
            this.Text = "Informatii comenzi si colete";

            //adaugare control de tip Label pentru 'IdComanda';
            lblIdComanda = new Label();
            lblIdComanda.Width = LATIME_CONTROL;
            lblIdComanda.Text = "Id Comanda";
            lblIdComanda.Left = DIMENSIUNE_PAS_X;
            lblIdComanda.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblIdComanda);

            //adaugare control de tip TextBox pentru 'IDComanda';
            txtIDComanda = new TextBox();
            txtIDComanda.Width = LATIME_CONTROL;
            txtIDComanda.Left = DIMENSIUNE_PAS_X;
            txtIDComanda.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtIDComanda);

            // aduaga control de tip label pentru eroare IDComanda
            eroareIDComanda = new Label();
            eroareIDComanda.Width = LATIME_CONTROL;
            eroareIDComanda.Left = DIMENSIUNE_PAS_X;
            eroareIDComanda.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareIDComanda.ForeColor = Color.Red;
            this.Controls.Add(eroareIDComanda);


            //adaugare control de tip Label pentru 'NumeClient';
            lblNumeClient = new Label();
            lblNumeClient.Width = LATIME_CONTROL;
            lblNumeClient.Text = "Nume Client";
            lblNumeClient.Left = 2 * DIMENSIUNE_PAS_X;
            lblNumeClient.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblNumeClient);

            //adaugare control de tip TextBox pentru 'NumeClient';
            txtNumeClient = new TextBox();
            txtNumeClient.Width = LATIME_CONTROL;
            txtNumeClient.Left = 2* DIMENSIUNE_PAS_X;
            txtNumeClient.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtNumeClient);

            //aduaga control de tip label pentru eroare NumeClient
 
            eroareNumeClient = new Label();
            eroareNumeClient.Width = LATIME_CONTROL;
            eroareNumeClient.Left = 2 * DIMENSIUNE_PAS_X;
            eroareNumeClient.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareNumeClient.ForeColor = Color.Red;
            this.Controls.Add(eroareNumeClient);

            //adaugare control de tip Label pentru 'AdresaLivrare';
            lblAdresaLivrare = new Label();
            lblAdresaLivrare.Width = LATIME_CONTROL;
            lblAdresaLivrare.Text = "Adresa Livrare";
            lblAdresaLivrare.Left = 3 * DIMENSIUNE_PAS_X;
            lblAdresaLivrare.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblAdresaLivrare);

            //adaugare control de tip TextBox pentru 'AdresaLivrare';
            txtAdresaLivrare = new TextBox();
            txtAdresaLivrare.Width = LATIME_CONTROL;
            txtAdresaLivrare.Left = 3 * DIMENSIUNE_PAS_X;
            txtAdresaLivrare.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtAdresaLivrare);

            //aduaga control de tip label pentru eroare AdresaLivrare
            eroareAdresaLivrare = new Label();
            eroareAdresaLivrare.Width = LATIME_CONTROL;
            eroareAdresaLivrare.Left = 3 * DIMENSIUNE_PAS_X;
            eroareAdresaLivrare.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareAdresaLivrare.ForeColor = Color.Red;
            this.Controls.Add(eroareAdresaLivrare);

            //adaugare control de tip Label pentru 'DataLivrare';
            lblDataLivrare = new Label();
            lblDataLivrare.Width = LATIME_CONTROL;
            lblDataLivrare.Text = "Data Livrare";
            lblDataLivrare.Left = 4 * DIMENSIUNE_PAS_X;
            lblDataLivrare.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblDataLivrare);

            //adaugare control de tip TextBox pentru 'DataLivrare';
            txtDataLivrare = new TextBox();
            txtDataLivrare.Width = LATIME_CONTROL;
            txtDataLivrare.Left = 4 * DIMENSIUNE_PAS_X;
            txtDataLivrare.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtDataLivrare);

            //aduaga control de tip label pentru eroare DataLivrare
            eroareDataLivrare = new Label();
            eroareDataLivrare.Width = LATIME_CONTROL;
            eroareDataLivrare.Left = 4 * DIMENSIUNE_PAS_X;
            eroareDataLivrare.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareDataLivrare.ForeColor = Color.Red;
            this.Controls.Add(eroareDataLivrare);

            //adaugare control de tip Label pentru 'StareComanda';
            lblStareComanda = new Label();
            lblStareComanda.Width = LATIME_CONTROL;
            lblStareComanda.Text = "Stare Comanda";
            lblStareComanda.Left = 5 * DIMENSIUNE_PAS_X;
            lblStareComanda.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblStareComanda);

            //adaugare control de tip TextBox pentru 'StareComanda';
            txtStareComanda = new TextBox();
            txtStareComanda.Width = LATIME_CONTROL;
            txtStareComanda.Left = 5 * DIMENSIUNE_PAS_X;
            txtStareComanda.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtStareComanda);

            //aduaga control de tip label pentru eroare StareComanda
            eroareStareComanda = new Label();
            eroareStareComanda.Width = LATIME_CONTROL;
            eroareStareComanda.Left = 5 * DIMENSIUNE_PAS_X;
            eroareStareComanda.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareStareComanda.ForeColor = Color.Red;
            this.Controls.Add(eroareStareComanda);
            

            //adaugare control de tip Label pentru 'IdColet';
            lblIdColet = new Label();
            lblIdColet.Width = LATIME_CONTROL;
            lblIdColet.Text = "Id Colet";
            lblIdColet.Left = 6 * DIMENSIUNE_PAS_X;
            lblIdColet.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblIdColet);

            //adaugare control de tip TextBox pentru 'IDColet';
            txtIDColet = new TextBox();
            txtIDColet.Width = LATIME_CONTROL;
            txtIDColet.Left = 6 * DIMENSIUNE_PAS_X;
            txtIDColet.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtIDColet);

            //aduaga control de tip label pentru eroare IDColet
            eroareIDColet = new Label();
            eroareIDColet.Width = LATIME_CONTROL;
            eroareIDColet.Left = 6 * DIMENSIUNE_PAS_X;
            eroareIDColet.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareIDColet.ForeColor = Color.Red;
            this.Controls.Add(eroareIDColet);


            //adaugare control de tip Label pentru 'Descriere';
            lblDescriere = new Label();
            lblDescriere.Width = LATIME_CONTROL;
            lblDescriere.Text = "Descriere";
            lblDescriere.Left = 7 * DIMENSIUNE_PAS_X;
            lblDescriere.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblDescriere);

            //adaugare control de tip TextBox pentru 'Descriere';
            txtDescriere = new TextBox();
            txtDescriere.Width = LATIME_CONTROL;
            txtDescriere.Left = 7 * DIMENSIUNE_PAS_X;
            txtDescriere.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtDescriere);

            //aduaga control de tip label pentru eroare Descriere
            eroareDescriere = new Label();
            eroareDescriere.Width = LATIME_CONTROL;
            eroareDescriere.Left = 7 * DIMENSIUNE_PAS_X;
            eroareDescriere.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareDescriere.ForeColor = Color.Red;
            this.Controls.Add(eroareDescriere);
               

            //adaugare control de tip Label pentru 'Greutate';
            lblGreutate = new Label();
            lblGreutate.Width = LATIME_CONTROL;
            lblGreutate.Text = "Greutate";
            lblGreutate.Left = 8 * DIMENSIUNE_PAS_X;
            lblGreutate.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblGreutate);

            //adaugare control de tip TextBox pentru 'Greutate';
            txtGreutate = new TextBox();
            txtGreutate.Width = LATIME_CONTROL;
            txtGreutate.Left = 8 * DIMENSIUNE_PAS_X;
            txtGreutate.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtGreutate);

            //aduaga control de tip label pentru eroare Greutate
            eroareGreutate = new Label();
            eroareGreutate.Width = LATIME_CONTROL;
            eroareGreutate.Left = 8 * DIMENSIUNE_PAS_X;
            eroareGreutate.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareGreutate.ForeColor = Color.Red;
            this.Controls.Add(eroareGreutate);


            //adaugare control de tip Label pentru 'Dimensiune';
            lblDimensiune = new Label();
            lblDimensiune.Width = LATIME_CONTROL;
            lblDimensiune.Text = "Dimensiune";
            lblDimensiune.Left = 9 * DIMENSIUNE_PAS_X;
            lblDimensiune.ForeColor = Color.FromArgb(3, 76, 83);
            this.Controls.Add(lblDimensiune);

            //adaugare control de tip TextBox pentru 'Dimensiune';
            txtDimensiune = new TextBox();
            txtDimensiune.Width = LATIME_CONTROL;
            txtDimensiune.Left = 9 * DIMENSIUNE_PAS_X;
            txtDimensiune.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtDimensiune);

            //aduaga control de tip label pentru eroare Dimensiune
            eroareDimensiune = new Label();
            eroareDimensiune.Width = LATIME_CONTROL;
            eroareDimensiune.Left = 9 * DIMENSIUNE_PAS_X;
            eroareDimensiune.Top = 2 * DIMENSIUNE_PAS_Y;
            eroareDimensiune.ForeColor = Color.Red;
            this.Controls.Add(eroareDimensiune);

            //adaugare control de tip Button Adauga
            buttonAdauga = new Button();
            buttonAdauga.Width = LATIME_CONTROL;
            buttonAdauga.Location = new System.Drawing.Point(0 * DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            buttonAdauga.Text = "Adauga Comanda";
            buttonAdauga.Click += OnButtonAdaugaClicked;                                    
            this.Controls.Add(buttonAdauga);

            //adaugare control de tip Button Refresh
            buttonRefresh = new Button();
            buttonRefresh.Width = LATIME_CONTROL;
            buttonRefresh.Location = new System.Drawing.Point(0 * DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            buttonRefresh.Text = "Refresh";
            buttonRefresh.Click += OnButtonRefreshClicked;
            this.Controls.Add(buttonRefresh);

            this.Load += new EventHandler(Form1_Load);
        }


        private void OnButtonAdaugaClicked(object sender, EventArgs e)
        {
            eroareIDComanda.Text = "";
            eroareNumeClient.Text = "";
            eroareAdresaLivrare.Text = "";
            eroareDataLivrare.Text = "";
            eroareStareComanda.Text = "";
            eroareIDColet.Text = "";
            eroareDescriere.Text = "";
            eroareGreutate.Text = "";
            eroareDimensiune.Text = "";

            if (!Prevalidare() && !Validare())
            {
                int idComanda = int.Parse(txtIDComanda.Text);
                string numeClient = txtNumeClient.Text;
                string adresaLivrare = txtAdresaLivrare.Text;
                string dataLivrare = txtDataLivrare.Text;
                StareComanda stareComanda = (StareComanda)Enum.Parse(typeof(StareComanda), txtStareComanda.Text);
                int idColet = int.Parse(txtIDColet.Text);
                string descriere = txtDescriere.Text;
                double greutate = double.Parse(txtGreutate.Text);
                DimensiuneColet dimensiune = (DimensiuneColet)Enum.Parse(typeof(DimensiuneColet), txtDimensiune.Text);

                Colet colet = new Colet(idColet, descriere, greutate, dimensiune);
                Comanda comanda = new Comanda(idComanda, numeClient, adresaLivrare, dataLivrare, stareComanda, colet, idColet);

                gestiuneColete.AddColet(colet);
                gestiuneComenzi.AddComanda(comanda);

                MessageBox.Show("Comanda si coletul au fost adaugate cu succes!");
            }
        }



        private void OnButtonRefreshClicked(object sender, EventArgs e)
        {
            AfiseazaComenziSiColete();
        }



        public bool Prevalidare()
        {
            if (string.IsNullOrWhiteSpace(txtIDComanda.Text))
            {
                eroareIDComanda.Text = "Nu poate fi gol!";
                eroareIDComanda.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtNumeClient.Text))
            {
                eroareNumeClient.Text = "Nu poate fi gol!";
                eroareNumeClient.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtAdresaLivrare.Text))
            {
                eroareAdresaLivrare.Text = "Nu poate fi gol!";
                eroareAdresaLivrare.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtDataLivrare.Text))
            {
                eroareDataLivrare.Text = "Nu poate fi gol!";
                eroareDataLivrare.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtStareComanda.Text))
            {
                eroareStareComanda.Text = "Nu poate fi gol!";
                eroareStareComanda.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtIDColet.Text))
            {
                eroareIDColet.Text = "Nu poate fi gol!";
                eroareIDColet.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                eroareDescriere.Text = "Nu poate fi gol!";
                eroareDescriere.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtGreutate.Text))
            {
                eroareGreutate.Text = "Nu poate fi gol!";
                eroareGreutate.ForeColor = Color.Red;
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtDimensiune.Text))
            {
                eroareDimensiune.Text = "Nu poate fi gol!";
                eroareDimensiune.ForeColor = Color.Red;
                return true;
            }

            return false;
        }

        public bool Validare()
        {
            if (txtNumeClient.Text.Length > NR_MAX_CARACTERE)
            {
                eroareNumeClient.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareNumeClient.ForeColor = Color.Red;
                return true;
            }

            if (txtAdresaLivrare.Text.Length > NR_MAX_CARACTERE)
            {
                eroareAdresaLivrare.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareAdresaLivrare.ForeColor = Color.Red;
                return true;
            }

            if (txtDataLivrare.Text.Length > NR_MAX_CARACTERE)
            {
                eroareDataLivrare.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareDataLivrare.ForeColor = Color.Red;
                return true;
            }

            if (txtStareComanda.Text.Length > NR_MAX_CARACTERE)
            {
                eroareStareComanda.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareStareComanda.ForeColor = Color.Red;
                return true;
            }

            if (txtDescriere.Text.Length > NR_MAX_CARACTERE)
            {
                eroareDescriere.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareDescriere.ForeColor = Color.Red;
                return true;
            }

            if (txtDimensiune.Text.Length > NR_MAX_CARACTERE)
            {
                eroareDimensiune.Text = $"Nr. max > {NR_MAX_CARACTERE} caractere!";
                eroareDimensiune.ForeColor = Color.Red;
                return true;
            }

            if (!int.TryParse(txtIDComanda.Text, out _))
            {
                eroareIDComanda.Text = "Trebuie sa fie un numar intreg!";
                eroareIDComanda.ForeColor = Color.Red;
                return true;
            }

            if (!int.TryParse(txtIDColet.Text, out _))
            {
                eroareIDColet.Text = "Trebuie sa fie un numar intreg!";
                eroareIDColet.ForeColor = Color.Red;
                return true;
            }

            if (!double.TryParse(txtGreutate.Text, out _))
            {
                eroareGreutate.Text = "Trebuie sa fie un numar real!";
                eroareGreutate.ForeColor = Color.Red;
                return true;
            }

            return false;
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
                lblsComenzi[i, 0].Top = (i + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 0]);

                //adaugare control de tip Label pentru numele clientului
                lblsComenzi[i, 1] = new Label();
                lblsComenzi[i, 1].Width = LATIME_CONTROL;
                lblsComenzi[i, 1].Text = comanda.NumeClient;
                lblsComenzi[i, 1].Left = 2 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 1].Top = (i + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 1]);

                //adaugare control de tip Label pentru adresa livrarii
                lblsComenzi[i, 2] = new Label();
                lblsComenzi[i, 2].Width = LATIME_CONTROL;
                lblsComenzi[i, 2].Text = comanda.AdresaLivrare;
                lblsComenzi[i, 2].Left = 3 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 2].Top = (i + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 2]);

                //adaugare control de tip Label pentru data livrarii
                lblsComenzi[i, 3] = new Label();
                lblsComenzi[i, 3].Width = LATIME_CONTROL;
                lblsComenzi[i, 3].Text = comanda.DataLivrare.ToString();
                lblsComenzi[i, 3].Left = 4 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 3].Top = (i + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsComenzi[i, 3]);

                //adaugare control de tip Label pentru starea comenzii
                lblsComenzi[i, 4] = new Label();
                lblsComenzi[i, 4].Width = LATIME_CONTROL;
                lblsComenzi[i, 4].Text = comanda.StareComanda.ToString();
                lblsComenzi[i, 4].Left = 5 * DIMENSIUNE_PAS_X;
                lblsComenzi[i, 4].Top = (i + 3) * DIMENSIUNE_PAS_Y;
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
                lblsColete[j, 0].Top = (j + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 0]);

                //adaugare control de tip Label pentru descrierea coletului
                lblsColete[j, 1] = new Label();
                lblsColete[j, 1].Width = LATIME_CONTROL;
                lblsColete[j, 1].Text = colet.Descriere;
                lblsColete[j, 1].Left = 7 * DIMENSIUNE_PAS_X;
                lblsColete[j, 1].Top = (j + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 1]);

                //adaugare control de tip Label pentru greutatea coletului
                lblsColete[j, 2] = new Label();
                lblsColete[j, 2].Width = LATIME_CONTROL;
                lblsColete[j, 2].Text = colet.Greutate.ToString();
                lblsColete[j, 2].Left = 8 * DIMENSIUNE_PAS_X;
                lblsColete[j, 2].Top = (j + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 2]);

                //adaugare control de tip Label pentru dimensiunea coletului
                lblsColete[j, 3] = new Label();
                lblsColete[j, 3].Width = LATIME_CONTROL;
                lblsColete[j, 3].Text = colet.GetDimensiuneText();
                lblsColete[j, 3].Left = 9 * DIMENSIUNE_PAS_X;
                lblsColete[j, 3].Top = (j + 3) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsColete[j, 3]);
                j++;
            }
        }

    }
}