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
            this.mtxtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.mlblEroareNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareGreutate = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mtSalveaza = new MetroFramework.Controls.MetroTile();
            this.nUDGreutate = new System.Windows.Forms.NumericUpDown();
            this.mlblOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mCmbStareComanda = new MetroFramework.Controls.MetroComboBox();
            this.mlblEroareStareComanda = new MetroFramework.Controls.MetroLabel();
            this.ckbLivrareDuminica = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckbLivrareSambata = new System.Windows.Forms.CheckBox();
            this.ckbNone = new System.Windows.Forms.CheckBox();
            this.ckbAsigurareColet = new System.Windows.Forms.CheckBox();
            this.ckbFragil = new System.Windows.Forms.CheckBox();
            this.ckbLivrareRapida = new System.Windows.Forms.CheckBox();
            this.gpbDimensiuneColet = new System.Windows.Forms.GroupBox();
            this.rdbExtraMare = new System.Windows.Forms.RadioButton();
            this.rdbMic = new System.Windows.Forms.RadioButton();
            this.rdbMareMare = new System.Windows.Forms.RadioButton();
            this.rdbMediuMic = new System.Windows.Forms.RadioButton();
            this.rdbMareStandard = new System.Windows.Forms.RadioButton();
            this.rdbMediuStandard = new System.Windows.Forms.RadioButton();
            this.rdbMareMica = new System.Windows.Forms.RadioButton();
            this.rdbMediuMare = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGreutate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbDimensiuneColet.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlblNumeClient
            // 
            this.mlblNumeClient.AutoSize = true;
            this.mlblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblNumeClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblNumeClient.Location = new System.Drawing.Point(15, 80);
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
            this.mlblAdresaLivrare.Location = new System.Drawing.Point(15, 107);
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
            this.mlblDataLivrare.Location = new System.Drawing.Point(15, 133);
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
            this.mlblStareComanda.Location = new System.Drawing.Point(15, 167);
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
            this.mlblDescriere.Location = new System.Drawing.Point(15, 303);
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
            this.mlblGreutate.Location = new System.Drawing.Point(17, 331);
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
            this.mlblDimensiune.Location = new System.Drawing.Point(15, 358);
            this.mlblDimensiune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDimensiune.Name = "mlblDimensiune";
            this.mlblDimensiune.Size = new System.Drawing.Size(121, 19);
            this.mlblDimensiune.TabIndex = 8;
            this.mlblDimensiune.Text = "Dimensiune Colet ";
            // 
            // mtxtNumeClient
            // 
            this.mtxtNumeClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtNumeClient.Location = new System.Drawing.Point(153, 80);
            this.mtxtNumeClient.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtNumeClient.Name = "mtxtNumeClient";
            this.mtxtNumeClient.Size = new System.Drawing.Size(242, 16);
            this.mtxtNumeClient.TabIndex = 10;
            // 
            // mtxtAdresaLivrare
            // 
            this.mtxtAdresaLivrare.Location = new System.Drawing.Point(153, 107);
            this.mtxtAdresaLivrare.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtAdresaLivrare.Name = "mtxtAdresaLivrare";
            this.mtxtAdresaLivrare.Size = new System.Drawing.Size(242, 16);
            this.mtxtAdresaLivrare.TabIndex = 11;
            // 
            // mtxtDataLivrare
            // 
            this.mtxtDataLivrare.Location = new System.Drawing.Point(153, 133);
            this.mtxtDataLivrare.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDataLivrare.Name = "mtxtDataLivrare";
            this.mtxtDataLivrare.Size = new System.Drawing.Size(242, 16);
            this.mtxtDataLivrare.TabIndex = 12;
            // 
            // mtxtDescriere
            // 
            this.mtxtDescriere.Location = new System.Drawing.Point(153, 303);
            this.mtxtDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDescriere.Name = "mtxtDescriere";
            this.mtxtDescriere.Size = new System.Drawing.Size(242, 16);
            this.mtxtDescriere.TabIndex = 15;
            // 
            // mlblEroareNumeClient
            // 
            this.mlblEroareNumeClient.AutoSize = true;
            this.mlblEroareNumeClient.CustomForeColor = true;
            this.mlblEroareNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareNumeClient.Location = new System.Drawing.Point(411, 77);
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
            this.mlblEroareAdresaLivrare.Location = new System.Drawing.Point(411, 104);
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
            this.mlblEroareDataLivrare.Location = new System.Drawing.Point(411, 131);
            this.mlblEroareDataLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareDataLivrare.Name = "mlblEroareDataLivrare";
            this.mlblEroareDataLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDataLivrare.TabIndex = 21;
            // 
            // mlblEroareDescriere
            // 
            this.mlblEroareDescriere.AutoSize = true;
            this.mlblEroareDescriere.CustomForeColor = true;
            this.mlblEroareDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDescriere.Location = new System.Drawing.Point(411, 303);
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
            this.mlblEroareGreutate.Location = new System.Drawing.Point(411, 332);
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
            this.mlblEroareDimensiune.Location = new System.Drawing.Point(411, 358);
            this.mlblEroareDimensiune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareDimensiune.Name = "mlblEroareDimensiune";
            this.mlblEroareDimensiune.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDimensiune.TabIndex = 26;
            // 
            // mtSalveaza
            // 
            this.mtSalveaza.BackColor = System.Drawing.Color.LightSlateGray;
            this.mtSalveaza.CustomBackground = true;
            this.mtSalveaza.Location = new System.Drawing.Point(153, 493);
            this.mtSalveaza.Margin = new System.Windows.Forms.Padding(2);
            this.mtSalveaza.Name = "mtSalveaza";
            this.mtSalveaza.Size = new System.Drawing.Size(242, 44);
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
            this.nUDGreutate.Location = new System.Drawing.Point(153, 331);
            this.nUDGreutate.Name = "nUDGreutate";
            this.nUDGreutate.Size = new System.Drawing.Size(243, 20);
            this.nUDGreutate.TabIndex = 29;
            // 
            // mlblOptiuniLivrare
            // 
            this.mlblOptiuniLivrare.AutoSize = true;
            this.mlblOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblOptiuniLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblOptiuniLivrare.Location = new System.Drawing.Point(15, 200);
            this.mlblOptiuniLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblOptiuniLivrare.Name = "mlblOptiuniLivrare";
            this.mlblOptiuniLivrare.Size = new System.Drawing.Size(100, 19);
            this.mlblOptiuniLivrare.TabIndex = 30;
            this.mlblOptiuniLivrare.Text = "Optiuni Livrare";
            // 
            // mlblEroareOptiuniLivrare
            // 
            this.mlblEroareOptiuniLivrare.AutoSize = true;
            this.mlblEroareOptiuniLivrare.CustomForeColor = true;
            this.mlblEroareOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareOptiuniLivrare.Location = new System.Drawing.Point(411, 200);
            this.mlblEroareOptiuniLivrare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareOptiuniLivrare.Name = "mlblEroareOptiuniLivrare";
            this.mlblEroareOptiuniLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareOptiuniLivrare.TabIndex = 48;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbLivrareDuminica);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.ckbLivrareSambata);
            this.groupBox1.Controls.Add(this.ckbNone);
            this.groupBox1.Controls.Add(this.ckbAsigurareColet);
            this.groupBox1.Controls.Add(this.ckbFragil);
            this.groupBox1.Controls.Add(this.ckbLivrareRapida);
            this.groupBox1.Location = new System.Drawing.Point(152, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 92);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // mCmbStareComanda
            // 
            this.mCmbStareComanda.FormattingEnabled = true;
            this.mCmbStareComanda.ItemHeight = 23;
            this.mCmbStareComanda.Location = new System.Drawing.Point(152, 162);
            this.mCmbStareComanda.Name = "mCmbStareComanda";
            this.mCmbStareComanda.Size = new System.Drawing.Size(243, 29);
            this.mCmbStareComanda.TabIndex = 50;
            // 
            // mlblEroareStareComanda
            // 
            this.mlblEroareStareComanda.AutoSize = true;
            this.mlblEroareStareComanda.CustomForeColor = true;
            this.mlblEroareStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareStareComanda.Location = new System.Drawing.Point(411, 165);
            this.mlblEroareStareComanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblEroareStareComanda.Name = "mlblEroareStareComanda";
            this.mlblEroareStareComanda.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareStareComanda.TabIndex = 22;
            // 
            // ckbLivrareDuminica
            // 
            this.ckbLivrareDuminica.AutoSize = true;
            this.ckbLivrareDuminica.Location = new System.Drawing.Point(118, 70);
            this.ckbLivrareDuminica.Name = "ckbLivrareDuminica";
            this.ckbLivrareDuminica.Size = new System.Drawing.Size(105, 17);
            this.ckbLivrareDuminica.TabIndex = 90;
            this.ckbLivrareDuminica.Text = "Livrare-Duminica";
            this.ckbLivrareDuminica.UseVisualStyleBackColor = true;
            this.ckbLivrareDuminica.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 86;
            this.checkBox1.Text = "Perisabil";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareSambata
            // 
            this.ckbLivrareSambata.AutoSize = true;
            this.ckbLivrareSambata.Location = new System.Drawing.Point(17, 70);
            this.ckbLivrareSambata.Name = "ckbLivrareSambata";
            this.ckbLivrareSambata.Size = new System.Drawing.Size(103, 17);
            this.ckbLivrareSambata.TabIndex = 89;
            this.ckbLivrareSambata.Text = "Livrare-Sambata";
            this.ckbLivrareSambata.UseVisualStyleBackColor = true;
            this.ckbLivrareSambata.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbNone
            // 
            this.ckbNone.AutoSize = true;
            this.ckbNone.Location = new System.Drawing.Point(17, 19);
            this.ckbNone.Name = "ckbNone";
            this.ckbNone.Size = new System.Drawing.Size(52, 17);
            this.ckbNone.TabIndex = 84;
            this.ckbNone.Text = "None";
            this.ckbNone.UseVisualStyleBackColor = true;
            this.ckbNone.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbAsigurareColet
            // 
            this.ckbAsigurareColet.AutoSize = true;
            this.ckbAsigurareColet.Location = new System.Drawing.Point(118, 46);
            this.ckbAsigurareColet.Name = "ckbAsigurareColet";
            this.ckbAsigurareColet.Size = new System.Drawing.Size(97, 17);
            this.ckbAsigurareColet.TabIndex = 88;
            this.ckbAsigurareColet.Text = "Asigurare-Colet";
            this.ckbAsigurareColet.UseVisualStyleBackColor = true;
            this.ckbAsigurareColet.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbFragil
            // 
            this.ckbFragil.AutoSize = true;
            this.ckbFragil.Location = new System.Drawing.Point(75, 18);
            this.ckbFragil.Name = "ckbFragil";
            this.ckbFragil.Size = new System.Drawing.Size(51, 17);
            this.ckbFragil.TabIndex = 85;
            this.ckbFragil.Text = "Fragil";
            this.ckbFragil.UseVisualStyleBackColor = true;
            this.ckbFragil.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareRapida
            // 
            this.ckbLivrareRapida.AutoSize = true;
            this.ckbLivrareRapida.Location = new System.Drawing.Point(17, 46);
            this.ckbLivrareRapida.Name = "ckbLivrareRapida";
            this.ckbLivrareRapida.Size = new System.Drawing.Size(95, 17);
            this.ckbLivrareRapida.TabIndex = 87;
            this.ckbLivrareRapida.Text = "Livrare-Rapida";
            this.ckbLivrareRapida.UseVisualStyleBackColor = true;
            this.ckbLivrareRapida.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // gpbDimensiuneColet
            // 
            this.gpbDimensiuneColet.Controls.Add(this.rdbExtraMare);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMic);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMareMare);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMediuMic);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMareStandard);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMediuStandard);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMareMica);
            this.gpbDimensiuneColet.Controls.Add(this.rdbMediuMare);
            this.gpbDimensiuneColet.Location = new System.Drawing.Point(152, 358);
            this.gpbDimensiuneColet.Name = "gpbDimensiuneColet";
            this.gpbDimensiuneColet.Size = new System.Drawing.Size(243, 118);
            this.gpbDimensiuneColet.TabIndex = 73;
            this.gpbDimensiuneColet.TabStop = false;
            // 
            // rdbExtraMare
            // 
            this.rdbExtraMare.AutoSize = true;
            this.rdbExtraMare.Location = new System.Drawing.Point(120, 92);
            this.rdbExtraMare.Name = "rdbExtraMare";
            this.rdbExtraMare.Size = new System.Drawing.Size(106, 17);
            this.rdbExtraMare.TabIndex = 84;
            this.rdbExtraMare.TabStop = true;
            this.rdbExtraMare.Text = "100x100x100 cm";
            this.rdbExtraMare.UseVisualStyleBackColor = true;
            // 
            // rdbMic
            // 
            this.rdbMic.AutoSize = true;
            this.rdbMic.Location = new System.Drawing.Point(17, 19);
            this.rdbMic.Name = "rdbMic";
            this.rdbMic.Size = new System.Drawing.Size(88, 17);
            this.rdbMic.TabIndex = 77;
            this.rdbMic.TabStop = true;
            this.rdbMic.Text = "30x30x30 cm";
            this.rdbMic.UseVisualStyleBackColor = true;
            // 
            // rdbMareMare
            // 
            this.rdbMareMare.AutoSize = true;
            this.rdbMareMare.Location = new System.Drawing.Point(17, 92);
            this.rdbMareMare.Name = "rdbMareMare";
            this.rdbMareMare.Size = new System.Drawing.Size(88, 17);
            this.rdbMareMare.TabIndex = 83;
            this.rdbMareMare.TabStop = true;
            this.rdbMareMare.Text = "90x90x90 cm";
            this.rdbMareMare.UseVisualStyleBackColor = true;
            // 
            // rdbMediuMic
            // 
            this.rdbMediuMic.AutoSize = true;
            this.rdbMediuMic.Location = new System.Drawing.Point(120, 19);
            this.rdbMediuMic.Name = "rdbMediuMic";
            this.rdbMediuMic.Size = new System.Drawing.Size(88, 17);
            this.rdbMediuMic.TabIndex = 78;
            this.rdbMediuMic.TabStop = true;
            this.rdbMediuMic.Text = "40x40x40 cm";
            this.rdbMediuMic.UseVisualStyleBackColor = true;
            // 
            // rdbMareStandard
            // 
            this.rdbMareStandard.AutoSize = true;
            this.rdbMareStandard.Location = new System.Drawing.Point(120, 66);
            this.rdbMareStandard.Name = "rdbMareStandard";
            this.rdbMareStandard.Size = new System.Drawing.Size(88, 17);
            this.rdbMareStandard.TabIndex = 82;
            this.rdbMareStandard.TabStop = true;
            this.rdbMareStandard.Text = "80x80x80 cm";
            this.rdbMareStandard.UseVisualStyleBackColor = true;
            // 
            // rdbMediuStandard
            // 
            this.rdbMediuStandard.AutoSize = true;
            this.rdbMediuStandard.Location = new System.Drawing.Point(17, 43);
            this.rdbMediuStandard.Name = "rdbMediuStandard";
            this.rdbMediuStandard.Size = new System.Drawing.Size(88, 17);
            this.rdbMediuStandard.TabIndex = 79;
            this.rdbMediuStandard.TabStop = true;
            this.rdbMediuStandard.Text = "50x50x50 cm";
            this.rdbMediuStandard.UseVisualStyleBackColor = true;
            // 
            // rdbMareMica
            // 
            this.rdbMareMica.AutoSize = true;
            this.rdbMareMica.Location = new System.Drawing.Point(17, 66);
            this.rdbMareMica.Name = "rdbMareMica";
            this.rdbMareMica.Size = new System.Drawing.Size(88, 17);
            this.rdbMareMica.TabIndex = 81;
            this.rdbMareMica.TabStop = true;
            this.rdbMareMica.Text = "70x70x70 cm";
            this.rdbMareMica.UseVisualStyleBackColor = true;
            // 
            // rdbMediuMare
            // 
            this.rdbMediuMare.AutoSize = true;
            this.rdbMediuMare.Location = new System.Drawing.Point(120, 43);
            this.rdbMediuMare.Name = "rdbMediuMare";
            this.rdbMediuMare.Size = new System.Drawing.Size(88, 17);
            this.rdbMediuMare.TabIndex = 80;
            this.rdbMediuMare.TabStop = true;
            this.rdbMediuMare.Text = "60x60x60 cm";
            this.rdbMediuMare.UseVisualStyleBackColor = true;
            // 
            // FormAdaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 567);
            this.Controls.Add(this.gpbDimensiuneColet);
            this.Controls.Add(this.mCmbStareComanda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mlblEroareOptiuniLivrare);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MetroTextBox mtxtDescriere;
        private MetroLabel mlblEroareNumeClient;
        private MetroLabel mlblEroareAdresaLivrare;
        private MetroLabel mlblEroareDataLivrare;
        private MetroLabel mlblEroareDescriere;
        private MetroLabel mlblEroareGreutate;
        private MetroLabel mlblEroareDimensiune;
        private MetroTile mtSalveaza;
        private System.Windows.Forms.NumericUpDown nUDGreutate;
        private MetroLabel mlblOptiuniLivrare;
        private MetroLabel mlblEroareOptiuniLivrare;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroComboBox mCmbStareComanda;
        private MetroLabel mlblEroareStareComanda;
        private System.Windows.Forms.CheckBox ckbLivrareDuminica;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ckbLivrareSambata;
        private System.Windows.Forms.CheckBox ckbNone;
        private System.Windows.Forms.CheckBox ckbAsigurareColet;
        private System.Windows.Forms.CheckBox ckbFragil;
        private System.Windows.Forms.CheckBox ckbLivrareRapida;
        private System.Windows.Forms.GroupBox gpbDimensiuneColet;
        private System.Windows.Forms.RadioButton rdbExtraMare;
        private System.Windows.Forms.RadioButton rdbMic;
        private System.Windows.Forms.RadioButton rdbMareMare;
        private System.Windows.Forms.RadioButton rdbMediuMic;
        private System.Windows.Forms.RadioButton rdbMareStandard;
        private System.Windows.Forms.RadioButton rdbMediuStandard;
        private System.Windows.Forms.RadioButton rdbMareMica;
        private System.Windows.Forms.RadioButton rdbMediuMare;
    }
}