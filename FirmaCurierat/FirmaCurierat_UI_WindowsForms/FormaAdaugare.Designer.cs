using MetroFramework.Controls;

namespace FirmaCurierat_UI_WindowsForms
{
    partial class FormAdaugare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mlblNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mlblAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblStareComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblDescriere = new MetroFramework.Controls.MetroLabel();
            this.mlblGreutate = new MetroFramework.Controls.MetroLabel();
            this.mlblDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mtxtNumeClient = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAdresaLivrare = new MetroFramework.Controls.MetroTextBox();
            this.mtxtDataLivrare = new MetroFramework.Controls.MetroTextBox();
            this.mtxtStareComanda = new MetroFramework.Controls.MetroTextBox();
            this.mtxtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.mlblEroareNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareStareComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareGreutate = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mtSalveaza = new MetroFramework.Controls.MetroTile();
            this.nUDGreutate = new System.Windows.Forms.NumericUpDown();
            this.mlblOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            this.ckbNone = new System.Windows.Forms.CheckBox();
            this.ckbPerisabil = new System.Windows.Forms.CheckBox();
            this.ckbFragil = new System.Windows.Forms.CheckBox();
            this.ckbLivrareRapida = new System.Windows.Forms.CheckBox();
            this.ckbAsigurareColet = new System.Windows.Forms.CheckBox();
            this.ckbLivrareSambata = new System.Windows.Forms.CheckBox();
            this.ckbLivrareDuminica = new System.Windows.Forms.CheckBox();
            this.mrdbMic = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMediuMic = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMediuStandard = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMediuMare = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMareMica = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMareStandard = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbMareMare = new MetroFramework.Controls.MetroRadioButton();
            this.mrdbExtraMare = new MetroFramework.Controls.MetroRadioButton();
            this.gpbOptiuniLivrare = new System.Windows.Forms.GroupBox();
            this.gpbDimensiuneColet = new System.Windows.Forms.GroupBox();
            this.mlblEroareOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGreutate)).BeginInit();
            this.gpbOptiuniLivrare.SuspendLayout();
            this.gpbDimensiuneColet.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlblNumeClient
            // 
            this.mlblNumeClient.AutoSize = true;
            this.mlblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblNumeClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblNumeClient.Location = new System.Drawing.Point(12, 78);
            this.mlblNumeClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblNumeClient.Name = "mlblNumeClient";
            this.mlblNumeClient.Size = new System.Drawing.Size(85, 19);
            this.mlblNumeClient.TabIndex = 0;
            this.mlblNumeClient.Text = "Nume Client";
            // 
            // mlblAdresaLivrare
            // 
            this.mlblAdresaLivrare.AutoSize = true;
            this.mlblAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblAdresaLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblAdresaLivrare.Location = new System.Drawing.Point(12, 105);
            this.mlblAdresaLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblAdresaLivrare.Name = "mlblAdresaLivrare";
            this.mlblAdresaLivrare.Size = new System.Drawing.Size(96, 19);
            this.mlblAdresaLivrare.TabIndex = 1;
            this.mlblAdresaLivrare.Text = "Adresa Livrare";
            // 
            // mlblDataLivrare
            // 
            this.mlblDataLivrare.AutoSize = true;
            this.mlblDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDataLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDataLivrare.Location = new System.Drawing.Point(12, 131);
            this.mlblDataLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDataLivrare.Name = "mlblDataLivrare";
            this.mlblDataLivrare.Size = new System.Drawing.Size(83, 19);
            this.mlblDataLivrare.TabIndex = 3;
            this.mlblDataLivrare.Text = "Data Livrare";
            // 
            // mlblStareComanda
            // 
            this.mlblStareComanda.AutoSize = true;
            this.mlblStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblStareComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblStareComanda.Location = new System.Drawing.Point(12, 157);
            this.mlblStareComanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblStareComanda.Name = "mlblStareComanda";
            this.mlblStareComanda.Size = new System.Drawing.Size(103, 19);
            this.mlblStareComanda.TabIndex = 4;
            this.mlblStareComanda.Text = "Stare Comanda";
            // 
            // mlblDescriere
            // 
            this.mlblDescriere.AutoSize = true;
            this.mlblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDescriere.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDescriere.Location = new System.Drawing.Point(13, 273);
            this.mlblDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDescriere.Name = "mlblDescriere";
            this.mlblDescriere.Size = new System.Drawing.Size(101, 19);
            this.mlblDescriere.TabIndex = 6;
            this.mlblDescriere.Text = "Descriere Colet";
            // 
            // mlblGreutate
            // 
            this.mlblGreutate.AutoSize = true;
            this.mlblGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblGreutate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblGreutate.Location = new System.Drawing.Point(15, 301);
            this.mlblGreutate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblGreutate.Name = "mlblGreutate";
            this.mlblGreutate.Size = new System.Drawing.Size(103, 19);
            this.mlblGreutate.TabIndex = 7;
            this.mlblGreutate.Text = "Greutate Colet ";
            // 
            // mlblDimensiune
            // 
            this.mlblDimensiune.AutoSize = true;
            this.mlblDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDimensiune.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDimensiune.Location = new System.Drawing.Point(13, 328);
            this.mlblDimensiune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDimensiune.Name = "mlblDimensiune";
            this.mlblDimensiune.Size = new System.Drawing.Size(121, 19);
            this.mlblDimensiune.TabIndex = 8;
            this.mlblDimensiune.Text = "Dimensiune Colet ";
            // 
            // mtxtNumeClient
            // 
            this.mtxtNumeClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtNumeClient.Location = new System.Drawing.Point(150, 78);
            this.mtxtNumeClient.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtNumeClient.Name = "mtxtNumeClient";
            this.mtxtNumeClient.Size = new System.Drawing.Size(221, 16);
            this.mtxtNumeClient.TabIndex = 10;
            // 
            // mtxtAdresaLivrare
            // 
            this.mtxtAdresaLivrare.Location = new System.Drawing.Point(150, 105);
            this.mtxtAdresaLivrare.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtAdresaLivrare.Name = "mtxtAdresaLivrare";
            this.mtxtAdresaLivrare.Size = new System.Drawing.Size(221, 16);
            this.mtxtAdresaLivrare.TabIndex = 11;
            // 
            // mtxtDataLivrare
            // 
            this.mtxtDataLivrare.Location = new System.Drawing.Point(150, 131);
            this.mtxtDataLivrare.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDataLivrare.Name = "mtxtDataLivrare";
            this.mtxtDataLivrare.Size = new System.Drawing.Size(221, 16);
            this.mtxtDataLivrare.TabIndex = 12;
            // 
            // mtxtStareComanda
            // 
            this.mtxtStareComanda.Location = new System.Drawing.Point(150, 157);
            this.mtxtStareComanda.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtStareComanda.Name = "mtxtStareComanda";
            this.mtxtStareComanda.Size = new System.Drawing.Size(221, 16);
            this.mtxtStareComanda.TabIndex = 13;
            // 
            // mtxtDescriere
            // 
            this.mtxtDescriere.Location = new System.Drawing.Point(151, 273);
            this.mtxtDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDescriere.Name = "mtxtDescriere";
            this.mtxtDescriere.Size = new System.Drawing.Size(222, 16);
            this.mtxtDescriere.TabIndex = 15;
            // 
            // mlblEroareNumeClient
            // 
            this.mlblEroareNumeClient.AutoSize = true;
            this.mlblEroareNumeClient.CustomForeColor = true;
            this.mlblEroareNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareNumeClient.Location = new System.Drawing.Point(379, 78);
            this.mlblEroareNumeClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareNumeClient.Name = "mlblEroareNumeClient";
            this.mlblEroareNumeClient.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareNumeClient.TabIndex = 19;
            // 
            // mlblEroareAdresaLivrare
            // 
            this.mlblEroareAdresaLivrare.AutoSize = true;
            this.mlblEroareAdresaLivrare.CustomForeColor = true;
            this.mlblEroareAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareAdresaLivrare.Location = new System.Drawing.Point(379, 105);
            this.mlblEroareAdresaLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareAdresaLivrare.Name = "mlblEroareAdresaLivrare";
            this.mlblEroareAdresaLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareAdresaLivrare.TabIndex = 20;
            // 
            // mlblEroareDataLivrare
            // 
            this.mlblEroareDataLivrare.AutoSize = true;
            this.mlblEroareDataLivrare.CustomForeColor = true;
            this.mlblEroareDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDataLivrare.Location = new System.Drawing.Point(379, 131);
            this.mlblEroareDataLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareDataLivrare.Name = "mlblEroareDataLivrare";
            this.mlblEroareDataLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDataLivrare.TabIndex = 21;
            // 
            // mlblEroareStareComanda
            // 
            this.mlblEroareStareComanda.AutoSize = true;
            this.mlblEroareStareComanda.CustomForeColor = true;
            this.mlblEroareStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareStareComanda.Location = new System.Drawing.Point(379, 157);
            this.mlblEroareStareComanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareStareComanda.Name = "mlblEroareStareComanda";
            this.mlblEroareStareComanda.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareStareComanda.TabIndex = 22;
            // 
            // mlblEroareDescriere
            // 
            this.mlblEroareDescriere.AutoSize = true;
            this.mlblEroareDescriere.CustomForeColor = true;
            this.mlblEroareDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDescriere.Location = new System.Drawing.Point(379, 273);
            this.mlblEroareDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareDescriere.Name = "mlblEroareDescriere";
            this.mlblEroareDescriere.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDescriere.TabIndex = 24;
            // 
            // mlblEroareGreutate
            // 
            this.mlblEroareGreutate.AutoSize = true;
            this.mlblEroareGreutate.CustomForeColor = true;
            this.mlblEroareGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareGreutate.Location = new System.Drawing.Point(379, 301);
            this.mlblEroareGreutate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareGreutate.Name = "mlblEroareGreutate";
            this.mlblEroareGreutate.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareGreutate.TabIndex = 25;
            // 
            // mlblEroareDimensiune
            // 
            this.mlblEroareDimensiune.AutoSize = true;
            this.mlblEroareDimensiune.CustomForeColor = true;
            this.mlblEroareDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDimensiune.Location = new System.Drawing.Point(379, 334);
            this.mlblEroareDimensiune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareDimensiune.Name = "mlblEroareDimensiune";
            this.mlblEroareDimensiune.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDimensiune.TabIndex = 26;
            // 
            // mtSalveaza
            // 
            this.mtSalveaza.BackColor = System.Drawing.Color.LightSlateGray;
            this.mtSalveaza.CustomBackground = true;
            this.mtSalveaza.Location = new System.Drawing.Point(151, 444);
            this.mtSalveaza.Margin = new System.Windows.Forms.Padding(2);
            this.mtSalveaza.Name = "mtSalveaza";
            this.mtSalveaza.Size = new System.Drawing.Size(222, 44);
            this.mtSalveaza.TabIndex = 28;
            this.mtSalveaza.Text = "Salveaza";
            this.mtSalveaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalveaza.Click += new System.EventHandler(this.mtSalveaza_Click);
            // 
            // nUDGreutate
            // 
            this.nUDGreutate.DecimalPlaces = 2;
            this.nUDGreutate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nUDGreutate.Location = new System.Drawing.Point(151, 301);
            this.nUDGreutate.Name = "nUDGreutate";
            this.nUDGreutate.Size = new System.Drawing.Size(222, 20);
            this.nUDGreutate.TabIndex = 29;
            // 
            // mlblOptiuniLivrare
            // 
            this.mlblOptiuniLivrare.AutoSize = true;
            this.mlblOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblOptiuniLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblOptiuniLivrare.Location = new System.Drawing.Point(12, 180);
            this.mlblOptiuniLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblOptiuniLivrare.Name = "mlblOptiuniLivrare";
            this.mlblOptiuniLivrare.Size = new System.Drawing.Size(100, 19);
            this.mlblOptiuniLivrare.TabIndex = 30;
            this.mlblOptiuniLivrare.Text = "Optiuni Livrare";
            // 
            // ckbNone
            // 
            this.ckbNone.AutoSize = true;
            this.ckbNone.Location = new System.Drawing.Point(14, 10);
            this.ckbNone.Name = "ckbNone";
            this.ckbNone.Size = new System.Drawing.Size(50, 18);
            this.ckbNone.TabIndex = 31;
            this.ckbNone.Text = "None";
            this.ckbNone.UseCompatibleTextRendering = true;
            this.ckbNone.UseVisualStyleBackColor = true;
            this.ckbNone.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbPerisabil
            // 
            this.ckbPerisabil.AutoSize = true;
            this.ckbPerisabil.Location = new System.Drawing.Point(81, 10);
            this.ckbPerisabil.Margin = new System.Windows.Forms.Padding(2);
            this.ckbPerisabil.Name = "ckbPerisabil";
            this.ckbPerisabil.Size = new System.Drawing.Size(67, 18);
            this.ckbPerisabil.TabIndex = 32;
            this.ckbPerisabil.Text = "Perisabil";
            this.ckbPerisabil.UseCompatibleTextRendering = true;
            this.ckbPerisabil.UseVisualStyleBackColor = true;
            this.ckbPerisabil.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbFragil
            // 
            this.ckbFragil.AutoSize = true;
            this.ckbFragil.Location = new System.Drawing.Point(161, 10);
            this.ckbFragil.Margin = new System.Windows.Forms.Padding(2);
            this.ckbFragil.Name = "ckbFragil";
            this.ckbFragil.Size = new System.Drawing.Size(52, 18);
            this.ckbFragil.TabIndex = 33;
            this.ckbFragil.Text = "Fragil";
            this.ckbFragil.UseCompatibleTextRendering = true;
            this.ckbFragil.UseVisualStyleBackColor = true;
            this.ckbFragil.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareRapida
            // 
            this.ckbLivrareRapida.AutoSize = true;
            this.ckbLivrareRapida.Location = new System.Drawing.Point(14, 34);
            this.ckbLivrareRapida.Name = "ckbLivrareRapida";
            this.ckbLivrareRapida.Size = new System.Drawing.Size(98, 18);
            this.ckbLivrareRapida.TabIndex = 34;
            this.ckbLivrareRapida.Text = "Livrare-Rapida";
            this.ckbLivrareRapida.UseCompatibleTextRendering = true;
            this.ckbLivrareRapida.UseVisualStyleBackColor = true;
            this.ckbLivrareRapida.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbAsigurareColet
            // 
            this.ckbAsigurareColet.AutoSize = true;
            this.ckbAsigurareColet.Location = new System.Drawing.Point(115, 32);
            this.ckbAsigurareColet.Name = "ckbAsigurareColet";
            this.ckbAsigurareColet.Size = new System.Drawing.Size(102, 18);
            this.ckbAsigurareColet.TabIndex = 35;
            this.ckbAsigurareColet.Text = "Asigurare-Colet";
            this.ckbAsigurareColet.UseCompatibleTextRendering = true;
            this.ckbAsigurareColet.UseVisualStyleBackColor = true;
            this.ckbAsigurareColet.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareSambata
            // 
            this.ckbLivrareSambata.AutoSize = true;
            this.ckbLivrareSambata.Location = new System.Drawing.Point(14, 55);
            this.ckbLivrareSambata.Name = "ckbLivrareSambata";
            this.ckbLivrareSambata.Size = new System.Drawing.Size(103, 17);
            this.ckbLivrareSambata.TabIndex = 36;
            this.ckbLivrareSambata.Text = "Livrare-Sambata";
            this.ckbLivrareSambata.UseVisualStyleBackColor = true;
            this.ckbLivrareSambata.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareDuminica
            // 
            this.ckbLivrareDuminica.AutoSize = true;
            this.ckbLivrareDuminica.Location = new System.Drawing.Point(115, 55);
            this.ckbLivrareDuminica.Name = "ckbLivrareDuminica";
            this.ckbLivrareDuminica.Size = new System.Drawing.Size(105, 17);
            this.ckbLivrareDuminica.TabIndex = 37;
            this.ckbLivrareDuminica.Text = "Livrare-Duminica";
            this.ckbLivrareDuminica.UseVisualStyleBackColor = true;
            this.ckbLivrareDuminica.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // mrdbMic
            // 
            this.mrdbMic.AutoSize = true;
            this.mrdbMic.Location = new System.Drawing.Point(6, 10);
            this.mrdbMic.Name = "mrdbMic";
            this.mrdbMic.Size = new System.Drawing.Size(89, 15);
            this.mrdbMic.TabIndex = 38;
            this.mrdbMic.TabStop = true;
            this.mrdbMic.Text = "30x30x30 cm";
            this.mrdbMic.UseVisualStyleBackColor = true;
            // 
            // mrdbMediuMic
            // 
            this.mrdbMediuMic.AutoSize = true;
            this.mrdbMediuMic.Location = new System.Drawing.Point(101, 11);
            this.mrdbMediuMic.Name = "mrdbMediuMic";
            this.mrdbMediuMic.Size = new System.Drawing.Size(89, 15);
            this.mrdbMediuMic.TabIndex = 39;
            this.mrdbMediuMic.TabStop = true;
            this.mrdbMediuMic.Text = "40x40x40 cm";
            this.mrdbMediuMic.UseCompatibleTextRendering = true;
            this.mrdbMediuMic.UseVisualStyleBackColor = true;
            // 
            // mrdbMediuStandard
            // 
            this.mrdbMediuStandard.AutoSize = true;
            this.mrdbMediuStandard.Location = new System.Drawing.Point(6, 31);
            this.mrdbMediuStandard.Name = "mrdbMediuStandard";
            this.mrdbMediuStandard.Size = new System.Drawing.Size(89, 15);
            this.mrdbMediuStandard.TabIndex = 40;
            this.mrdbMediuStandard.TabStop = true;
            this.mrdbMediuStandard.Text = "50x50x50 cm";
            this.mrdbMediuStandard.UseVisualStyleBackColor = true;
            // 
            // mrdbMediuMare
            // 
            this.mrdbMediuMare.AutoSize = true;
            this.mrdbMediuMare.Location = new System.Drawing.Point(101, 31);
            this.mrdbMediuMare.Name = "mrdbMediuMare";
            this.mrdbMediuMare.Size = new System.Drawing.Size(89, 15);
            this.mrdbMediuMare.TabIndex = 41;
            this.mrdbMediuMare.TabStop = true;
            this.mrdbMediuMare.Text = "60x60x60 cm";
            this.mrdbMediuMare.UseVisualStyleBackColor = true;
            // 
            // mrdbMareMica
            // 
            this.mrdbMareMica.AutoSize = true;
            this.mrdbMareMica.Location = new System.Drawing.Point(6, 52);
            this.mrdbMareMica.Name = "mrdbMareMica";
            this.mrdbMareMica.Size = new System.Drawing.Size(89, 15);
            this.mrdbMareMica.TabIndex = 42;
            this.mrdbMareMica.TabStop = true;
            this.mrdbMareMica.Text = "70x70x70 cm";
            this.mrdbMareMica.UseVisualStyleBackColor = true;
            // 
            // mrdbMareStandard
            // 
            this.mrdbMareStandard.AutoSize = true;
            this.mrdbMareStandard.Location = new System.Drawing.Point(101, 52);
            this.mrdbMareStandard.Name = "mrdbMareStandard";
            this.mrdbMareStandard.Size = new System.Drawing.Size(89, 15);
            this.mrdbMareStandard.TabIndex = 43;
            this.mrdbMareStandard.TabStop = true;
            this.mrdbMareStandard.Text = "80x80x80 cm";
            this.mrdbMareStandard.UseVisualStyleBackColor = true;
            // 
            // mrdbMareMare
            // 
            this.mrdbMareMare.AutoSize = true;
            this.mrdbMareMare.Location = new System.Drawing.Point(6, 73);
            this.mrdbMareMare.Name = "mrdbMareMare";
            this.mrdbMareMare.Size = new System.Drawing.Size(89, 15);
            this.mrdbMareMare.TabIndex = 44;
            this.mrdbMareMare.TabStop = true;
            this.mrdbMareMare.Text = "90x90x90 cm";
            this.mrdbMareMare.UseVisualStyleBackColor = true;
            // 
            // mrdbExtraMare
            // 
            this.mrdbExtraMare.AutoSize = true;
            this.mrdbExtraMare.Location = new System.Drawing.Point(101, 73);
            this.mrdbExtraMare.Name = "mrdbExtraMare";
            this.mrdbExtraMare.Size = new System.Drawing.Size(107, 15);
            this.mrdbExtraMare.TabIndex = 45;
            this.mrdbExtraMare.TabStop = true;
            this.mrdbExtraMare.Text = "100x100x100 cm";
            this.mrdbExtraMare.UseVisualStyleBackColor = true;
            // 
            // gpbOptiuniLivrare
            // 
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareDuminica);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbNone);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbPerisabil);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbFragil);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareRapida);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbAsigurareColet);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareSambata);
            this.gpbOptiuniLivrare.Location = new System.Drawing.Point(151, 185);
            this.gpbOptiuniLivrare.Name = "gpbOptiuniLivrare";
            this.gpbOptiuniLivrare.Size = new System.Drawing.Size(221, 83);
            this.gpbOptiuniLivrare.TabIndex = 46;
            this.gpbOptiuniLivrare.TabStop = false;
            // 
            // gpbDimensiuneColet
            // 
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMic);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMediuMic);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbExtraMare);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMediuStandard);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMareMare);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMediuMare);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMareStandard);
            this.gpbDimensiuneColet.Controls.Add(this.mrdbMareMica);
            this.gpbDimensiuneColet.Location = new System.Drawing.Point(150, 328);
            this.gpbDimensiuneColet.Name = "gpbDimensiuneColet";
            this.gpbDimensiuneColet.Size = new System.Drawing.Size(222, 97);
            this.gpbDimensiuneColet.TabIndex = 47;
            this.gpbDimensiuneColet.TabStop = false;
            // 
            // mlblEroareOptiuniLivrare
            // 
            this.mlblEroareOptiuniLivrare.AutoSize = true;
            this.mlblEroareOptiuniLivrare.CustomForeColor = true;
            this.mlblEroareOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareOptiuniLivrare.Location = new System.Drawing.Point(379, 193);
            this.mlblEroareOptiuniLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareOptiuniLivrare.Name = "mlblEroareOptiuniLivrare";
            this.mlblEroareOptiuniLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareOptiuniLivrare.TabIndex = 48;
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1336, 567);
            this.Controls.Add(this.mlblEroareOptiuniLivrare);
            this.Controls.Add(this.gpbDimensiuneColet);
            this.Controls.Add(this.gpbOptiuniLivrare);
            this.Controls.Add(this.mlblOptiuniLivrare);
            this.Controls.Add(this.nUDGreutate);
            this.Controls.Add(this.mtSalveaza);
            this.Controls.Add(this.mlblEroareDimensiune);
            this.Controls.Add(this.mlblEroareGreutate);
            this.Controls.Add(this.mlblEroareDescriere);
            this.Controls.Add(this.mlblEroareStareComanda);
            this.Controls.Add(this.mlblEroareDataLivrare);
            this.Controls.Add(this.mlblEroareAdresaLivrare);
            this.Controls.Add(this.mlblEroareNumeClient);
            this.Controls.Add(this.mtxtDescriere);
            this.Controls.Add(this.mtxtStareComanda);
            this.Controls.Add(this.mtxtDataLivrare);
            this.Controls.Add(this.mtxtAdresaLivrare);
            this.Controls.Add(this.mtxtNumeClient);
            this.Controls.Add(this.mlblDimensiune);
            this.Controls.Add(this.mlblGreutate);
            this.Controls.Add(this.mlblDescriere);
            this.Controls.Add(this.mlblStareComanda);
            this.Controls.Add(this.mlblDataLivrare);
            this.Controls.Add(this.mlblAdresaLivrare);
            this.Controls.Add(this.mlblNumeClient);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdaugare";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Adaugare comanda si colet";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.nUDGreutate)).EndInit();
            this.gpbOptiuniLivrare.ResumeLayout(false);
            this.gpbOptiuniLivrare.PerformLayout();
            this.gpbDimensiuneColet.ResumeLayout(false);
            this.gpbDimensiuneColet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private MetroLabel mlblNumeClient;
        private MetroLabel mlblAdresaLivrare;
        private MetroLabel mlblDataLivrare;
        private MetroLabel mlblStareComanda;
        private MetroLabel mlblDescriere;
        private MetroLabel mlblGreutate;
        private MetroLabel mlblDimensiune;
        private MetroTextBox mtxtNumeClient;
        private MetroTextBox mtxtAdresaLivrare;
        private MetroTextBox mtxtDataLivrare;
        private MetroTextBox mtxtStareComanda;
        private MetroTextBox mtxtDescriere;
        private MetroLabel mlblEroareNumeClient;
        private MetroLabel mlblEroareAdresaLivrare;
        private MetroLabel mlblEroareDataLivrare;
        private MetroLabel mlblEroareStareComanda;
        private MetroLabel mlblEroareDescriere;
        private MetroLabel mlblEroareGreutate;
        private MetroLabel mlblEroareDimensiune;
        private MetroTile mtSalveaza;
        private System.Windows.Forms.NumericUpDown nUDGreutate;
        private MetroLabel mlblOptiuniLivrare;
        private System.Windows.Forms.CheckBox ckbNone;
        private System.Windows.Forms.CheckBox ckbPerisabil;
        private System.Windows.Forms.CheckBox ckbFragil;
        private System.Windows.Forms.CheckBox ckbLivrareRapida;
        private System.Windows.Forms.CheckBox ckbAsigurareColet;
        private System.Windows.Forms.CheckBox ckbLivrareSambata;
        private System.Windows.Forms.CheckBox ckbLivrareDuminica;
        private MetroRadioButton mrdbMic;
        private MetroRadioButton mrdbMediuMic;
        private MetroRadioButton mrdbMediuStandard;
        private MetroRadioButton mrdbMediuMare;
        private MetroRadioButton mrdbMareMica;
        private MetroRadioButton mrdbMareStandard;
        private MetroRadioButton mrdbMareMare;
        private MetroRadioButton mrdbExtraMare;
        private System.Windows.Forms.GroupBox gpbOptiuniLivrare;
        private System.Windows.Forms.GroupBox gpbDimensiuneColet;
        private MetroLabel mlblEroareOptiuniLivrare;
    }
}