namespace FirmaCurierat_UI_WindowsForms
{
    partial class FormaModificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaModificare));
            this.gpbOptiuniLivrare = new System.Windows.Forms.GroupBox();
            this.ckbLivrareDuminica = new System.Windows.Forms.CheckBox();
            this.ckbPerisabil = new System.Windows.Forms.CheckBox();
            this.ckbLivrareSambata = new System.Windows.Forms.CheckBox();
            this.ckbAsigurareColet = new System.Windows.Forms.CheckBox();
            this.ckbFragil = new System.Windows.Forms.CheckBox();
            this.ckbLivrareRapida = new System.Windows.Forms.CheckBox();
            this.mlblEroareOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            this.gpbDimensiuneColet = new System.Windows.Forms.GroupBox();
            this.rdbExtraMare = new System.Windows.Forms.RadioButton();
            this.rdbMic = new System.Windows.Forms.RadioButton();
            this.rdbMareMare = new System.Windows.Forms.RadioButton();
            this.rdbMediuMic = new System.Windows.Forms.RadioButton();
            this.rdbMareStandard = new System.Windows.Forms.RadioButton();
            this.rdbMediuStandard = new System.Windows.Forms.RadioButton();
            this.rdbMareMica = new System.Windows.Forms.RadioButton();
            this.rdbMediuMare = new System.Windows.Forms.RadioButton();
            this.mlblOptiuniLivrare = new MetroFramework.Controls.MetroLabel();
            this.nUDGreutate = new System.Windows.Forms.NumericUpDown();
            this.mlblEroareDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareGreutate = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareStareComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mtxtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.mtxtAdresaLivrare = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNumeClient = new MetroFramework.Controls.MetroTextBox();
            this.mlblDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mlblGreutate = new MetroFramework.Controls.MetroLabel();
            this.mlblDescriere = new MetroFramework.Controls.MetroLabel();
            this.mlblStareComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.mlblNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mlblIDComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblIDColet = new MetroFramework.Controls.MetroLabel();
            this.mCmbStareComanda = new MetroFramework.Controls.MetroComboBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbModifica = new System.Windows.Forms.PictureBox();
            this.pnlModifica = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.dtpDataLivrare = new System.Windows.Forms.DateTimePicker();
            this.gpbOptiuniLivrare.SuspendLayout();
            this.gpbDimensiuneColet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGreutate)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifica)).BeginInit();
            this.pnlModifica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOptiuniLivrare
            // 
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareDuminica);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbPerisabil);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareSambata);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbAsigurareColet);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbFragil);
            this.gpbOptiuniLivrare.Controls.Add(this.ckbLivrareRapida);
            this.gpbOptiuniLivrare.Location = new System.Drawing.Point(286, 344);
            this.gpbOptiuniLivrare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpbOptiuniLivrare.Name = "gpbOptiuniLivrare";
            this.gpbOptiuniLivrare.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpbOptiuniLivrare.Size = new System.Drawing.Size(482, 177);
            this.gpbOptiuniLivrare.TabIndex = 74;
            this.gpbOptiuniLivrare.TabStop = false;
            // 
            // ckbLivrareDuminica
            // 
            this.ckbLivrareDuminica.AutoSize = true;
            this.ckbLivrareDuminica.Location = new System.Drawing.Point(228, 135);
            this.ckbLivrareDuminica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbLivrareDuminica.Name = "ckbLivrareDuminica";
            this.ckbLivrareDuminica.Size = new System.Drawing.Size(205, 29);
            this.ckbLivrareDuminica.TabIndex = 83;
            this.ckbLivrareDuminica.Text = "Livrare Duminica";
            this.ckbLivrareDuminica.UseVisualStyleBackColor = true;
            this.ckbLivrareDuminica.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbPerisabil
            // 
            this.ckbPerisabil.AutoSize = true;
            this.ckbPerisabil.Location = new System.Drawing.Point(228, 36);
            this.ckbPerisabil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbPerisabil.Name = "ckbPerisabil";
            this.ckbPerisabil.Size = new System.Drawing.Size(183, 29);
            this.ckbPerisabil.TabIndex = 79;
            this.ckbPerisabil.Text = "Colet Perisabil";
            this.ckbPerisabil.UseVisualStyleBackColor = true;
            this.ckbPerisabil.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareSambata
            // 
            this.ckbLivrareSambata.AutoSize = true;
            this.ckbLivrareSambata.Location = new System.Drawing.Point(26, 135);
            this.ckbLivrareSambata.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbLivrareSambata.Name = "ckbLivrareSambata";
            this.ckbLivrareSambata.Size = new System.Drawing.Size(201, 29);
            this.ckbLivrareSambata.TabIndex = 82;
            this.ckbLivrareSambata.Text = "Livrare Sambata";
            this.ckbLivrareSambata.UseVisualStyleBackColor = true;
            this.ckbLivrareSambata.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbAsigurareColet
            // 
            this.ckbAsigurareColet.AutoSize = true;
            this.ckbAsigurareColet.Location = new System.Drawing.Point(228, 88);
            this.ckbAsigurareColet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbAsigurareColet.Name = "ckbAsigurareColet";
            this.ckbAsigurareColet.Size = new System.Drawing.Size(192, 29);
            this.ckbAsigurareColet.TabIndex = 81;
            this.ckbAsigurareColet.Text = "Asigurare Colet";
            this.ckbAsigurareColet.UseVisualStyleBackColor = true;
            this.ckbAsigurareColet.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbFragil
            // 
            this.ckbFragil.AutoSize = true;
            this.ckbFragil.Location = new System.Drawing.Point(26, 36);
            this.ckbFragil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbFragil.Name = "ckbFragil";
            this.ckbFragil.Size = new System.Drawing.Size(154, 29);
            this.ckbFragil.TabIndex = 78;
            this.ckbFragil.Text = "Colet Fragil";
            this.ckbFragil.UseVisualStyleBackColor = true;
            this.ckbFragil.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // ckbLivrareRapida
            // 
            this.ckbLivrareRapida.AutoSize = true;
            this.ckbLivrareRapida.Location = new System.Drawing.Point(26, 88);
            this.ckbLivrareRapida.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ckbLivrareRapida.Name = "ckbLivrareRapida";
            this.ckbLivrareRapida.Size = new System.Drawing.Size(184, 29);
            this.ckbLivrareRapida.TabIndex = 80;
            this.ckbLivrareRapida.Text = "Livrare Rapida";
            this.ckbLivrareRapida.UseVisualStyleBackColor = true;
            this.ckbLivrareRapida.CheckedChanged += new System.EventHandler(this.CkbOptiuniLivare_CheckedChanged);
            // 
            // mlblEroareOptiuniLivrare
            // 
            this.mlblEroareOptiuniLivrare.AutoSize = true;
            this.mlblEroareOptiuniLivrare.CustomForeColor = true;
            this.mlblEroareOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareOptiuniLivrare.Location = new System.Drawing.Point(804, 350);
            this.mlblEroareOptiuniLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareOptiuniLivrare.Name = "mlblEroareOptiuniLivrare";
            this.mlblEroareOptiuniLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareOptiuniLivrare.TabIndex = 73;
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
            this.gpbDimensiuneColet.Location = new System.Drawing.Point(286, 654);
            this.gpbDimensiuneColet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpbDimensiuneColet.Name = "gpbDimensiuneColet";
            this.gpbDimensiuneColet.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpbDimensiuneColet.Size = new System.Drawing.Size(486, 227);
            this.gpbDimensiuneColet.TabIndex = 72;
            this.gpbDimensiuneColet.TabStop = false;
            // 
            // rdbExtraMare
            // 
            this.rdbExtraMare.AutoSize = true;
            this.rdbExtraMare.Location = new System.Drawing.Point(240, 177);
            this.rdbExtraMare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbExtraMare.Name = "rdbExtraMare";
            this.rdbExtraMare.Size = new System.Drawing.Size(207, 29);
            this.rdbExtraMare.TabIndex = 84;
            this.rdbExtraMare.TabStop = true;
            this.rdbExtraMare.Tag = "DimensiuneColet.ExtraMare";
            this.rdbExtraMare.Text = "100x100x100 cm";
            this.rdbExtraMare.UseVisualStyleBackColor = true;
            // 
            // rdbMic
            // 
            this.rdbMic.AutoSize = true;
            this.rdbMic.Location = new System.Drawing.Point(34, 37);
            this.rdbMic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMic.Name = "rdbMic";
            this.rdbMic.Size = new System.Drawing.Size(171, 29);
            this.rdbMic.TabIndex = 77;
            this.rdbMic.TabStop = true;
            this.rdbMic.Tag = "DimensiuneColet.Mic";
            this.rdbMic.Text = "30x30x30 cm";
            this.rdbMic.UseVisualStyleBackColor = true;
            // 
            // rdbMareMare
            // 
            this.rdbMareMare.AutoSize = true;
            this.rdbMareMare.Location = new System.Drawing.Point(34, 177);
            this.rdbMareMare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMareMare.Name = "rdbMareMare";
            this.rdbMareMare.Size = new System.Drawing.Size(171, 29);
            this.rdbMareMare.TabIndex = 83;
            this.rdbMareMare.TabStop = true;
            this.rdbMareMare.Tag = "DimensiuneColet.MareMare";
            this.rdbMareMare.Text = "90x90x90 cm";
            this.rdbMareMare.UseVisualStyleBackColor = true;
            // 
            // rdbMediuMic
            // 
            this.rdbMediuMic.AutoSize = true;
            this.rdbMediuMic.Location = new System.Drawing.Point(240, 37);
            this.rdbMediuMic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMediuMic.Name = "rdbMediuMic";
            this.rdbMediuMic.Size = new System.Drawing.Size(171, 29);
            this.rdbMediuMic.TabIndex = 78;
            this.rdbMediuMic.TabStop = true;
            this.rdbMediuMic.Tag = "DimensiuneColet.MediuMic";
            this.rdbMediuMic.Text = "40x40x40 cm";
            this.rdbMediuMic.UseVisualStyleBackColor = true;
            // 
            // rdbMareStandard
            // 
            this.rdbMareStandard.AutoSize = true;
            this.rdbMareStandard.Location = new System.Drawing.Point(240, 127);
            this.rdbMareStandard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMareStandard.Name = "rdbMareStandard";
            this.rdbMareStandard.Size = new System.Drawing.Size(171, 29);
            this.rdbMareStandard.TabIndex = 82;
            this.rdbMareStandard.TabStop = true;
            this.rdbMareStandard.Tag = "DimensiuneColet.MareStandard";
            this.rdbMareStandard.Text = "80x80x80 cm";
            this.rdbMareStandard.UseVisualStyleBackColor = true;
            // 
            // rdbMediuStandard
            // 
            this.rdbMediuStandard.AutoSize = true;
            this.rdbMediuStandard.Location = new System.Drawing.Point(34, 83);
            this.rdbMediuStandard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMediuStandard.Name = "rdbMediuStandard";
            this.rdbMediuStandard.Size = new System.Drawing.Size(171, 29);
            this.rdbMediuStandard.TabIndex = 79;
            this.rdbMediuStandard.TabStop = true;
            this.rdbMediuStandard.Tag = "DimensiuneColet.MediuStandard";
            this.rdbMediuStandard.Text = "50x50x50 cm";
            this.rdbMediuStandard.UseVisualStyleBackColor = true;
            // 
            // rdbMareMica
            // 
            this.rdbMareMica.AutoSize = true;
            this.rdbMareMica.Location = new System.Drawing.Point(34, 127);
            this.rdbMareMica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMareMica.Name = "rdbMareMica";
            this.rdbMareMica.Size = new System.Drawing.Size(171, 29);
            this.rdbMareMica.TabIndex = 81;
            this.rdbMareMica.TabStop = true;
            this.rdbMareMica.Tag = "DimensiuneColet.MareMica";
            this.rdbMareMica.Text = "70x70x70 cm";
            this.rdbMareMica.UseVisualStyleBackColor = true;
            // 
            // rdbMediuMare
            // 
            this.rdbMediuMare.AutoSize = true;
            this.rdbMediuMare.Location = new System.Drawing.Point(240, 83);
            this.rdbMediuMare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMediuMare.Name = "rdbMediuMare";
            this.rdbMediuMare.Size = new System.Drawing.Size(171, 29);
            this.rdbMediuMare.TabIndex = 80;
            this.rdbMediuMare.TabStop = true;
            this.rdbMediuMare.Tag = "DimensiuneColet.MediuMare";
            this.rdbMediuMare.Text = "60x60x60 cm";
            this.rdbMediuMare.UseVisualStyleBackColor = true;
            // 
            // mlblOptiuniLivrare
            // 
            this.mlblOptiuniLivrare.AutoSize = true;
            this.mlblOptiuniLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblOptiuniLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblOptiuniLivrare.Location = new System.Drawing.Point(12, 350);
            this.mlblOptiuniLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblOptiuniLivrare.Name = "mlblOptiuniLivrare";
            this.mlblOptiuniLivrare.Size = new System.Drawing.Size(100, 19);
            this.mlblOptiuniLivrare.TabIndex = 71;
            this.mlblOptiuniLivrare.Text = "Optiuni Livrare";
            // 
            // nUDGreutate
            // 
            this.nUDGreutate.DecimalPlaces = 2;
            this.nUDGreutate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nUDGreutate.Location = new System.Drawing.Point(288, 602);
            this.nUDGreutate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nUDGreutate.Name = "nUDGreutate";
            this.nUDGreutate.Size = new System.Drawing.Size(486, 31);
            this.nUDGreutate.TabIndex = 70;
            // 
            // mlblEroareDimensiune
            // 
            this.mlblEroareDimensiune.AutoSize = true;
            this.mlblEroareDimensiune.CustomForeColor = true;
            this.mlblEroareDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDimensiune.Location = new System.Drawing.Point(804, 654);
            this.mlblEroareDimensiune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareDimensiune.Name = "mlblEroareDimensiune";
            this.mlblEroareDimensiune.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDimensiune.TabIndex = 68;
            // 
            // mlblEroareGreutate
            // 
            this.mlblEroareGreutate.AutoSize = true;
            this.mlblEroareGreutate.CustomForeColor = true;
            this.mlblEroareGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareGreutate.Location = new System.Drawing.Point(804, 604);
            this.mlblEroareGreutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareGreutate.Name = "mlblEroareGreutate";
            this.mlblEroareGreutate.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareGreutate.TabIndex = 67;
            // 
            // mlblEroareDescriere
            // 
            this.mlblEroareDescriere.AutoSize = true;
            this.mlblEroareDescriere.CustomForeColor = true;
            this.mlblEroareDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDescriere.Location = new System.Drawing.Point(804, 548);
            this.mlblEroareDescriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareDescriere.Name = "mlblEroareDescriere";
            this.mlblEroareDescriere.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDescriere.TabIndex = 66;
            // 
            // mlblEroareStareComanda
            // 
            this.mlblEroareStareComanda.AutoSize = true;
            this.mlblEroareStareComanda.CustomForeColor = true;
            this.mlblEroareStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareStareComanda.Location = new System.Drawing.Point(804, 283);
            this.mlblEroareStareComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareStareComanda.Name = "mlblEroareStareComanda";
            this.mlblEroareStareComanda.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareStareComanda.TabIndex = 65;
            // 
            // mlblEroareDataLivrare
            // 
            this.mlblEroareDataLivrare.AutoSize = true;
            this.mlblEroareDataLivrare.CustomForeColor = true;
            this.mlblEroareDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareDataLivrare.Location = new System.Drawing.Point(804, 217);
            this.mlblEroareDataLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareDataLivrare.Name = "mlblEroareDataLivrare";
            this.mlblEroareDataLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDataLivrare.TabIndex = 64;
            // 
            // mlblEroareAdresaLivrare
            // 
            this.mlblEroareAdresaLivrare.AutoSize = true;
            this.mlblEroareAdresaLivrare.CustomForeColor = true;
            this.mlblEroareAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareAdresaLivrare.Location = new System.Drawing.Point(804, 165);
            this.mlblEroareAdresaLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareAdresaLivrare.Name = "mlblEroareAdresaLivrare";
            this.mlblEroareAdresaLivrare.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareAdresaLivrare.TabIndex = 63;
            // 
            // mlblEroareNumeClient
            // 
            this.mlblEroareNumeClient.AutoSize = true;
            this.mlblEroareNumeClient.CustomForeColor = true;
            this.mlblEroareNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblEroareNumeClient.Location = new System.Drawing.Point(804, 110);
            this.mlblEroareNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblEroareNumeClient.Name = "mlblEroareNumeClient";
            this.mlblEroareNumeClient.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareNumeClient.TabIndex = 62;
            // 
            // mtxtDescriere
            // 
            this.mtxtDescriere.Location = new System.Drawing.Point(288, 548);
            this.mtxtDescriere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtDescriere.Name = "mtxtDescriere";
            this.mtxtDescriere.Size = new System.Drawing.Size(484, 31);
            this.mtxtDescriere.TabIndex = 61;
            // 
            // mtxtAdresaLivrare
            // 
            this.mtxtAdresaLivrare.Location = new System.Drawing.Point(288, 171);
            this.mtxtAdresaLivrare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtAdresaLivrare.Name = "mtxtAdresaLivrare";
            this.mtxtAdresaLivrare.Size = new System.Drawing.Size(484, 31);
            this.mtxtAdresaLivrare.TabIndex = 59;
            // 
            // mtxtNumeClient
            // 
            this.mtxtNumeClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtNumeClient.Location = new System.Drawing.Point(288, 119);
            this.mtxtNumeClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtNumeClient.Name = "mtxtNumeClient";
            this.mtxtNumeClient.Size = new System.Drawing.Size(484, 31);
            this.mtxtNumeClient.TabIndex = 58;
            // 
            // mlblDimensiune
            // 
            this.mlblDimensiune.AutoSize = true;
            this.mlblDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDimensiune.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDimensiune.Location = new System.Drawing.Point(12, 654);
            this.mlblDimensiune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblDimensiune.Name = "mlblDimensiune";
            this.mlblDimensiune.Size = new System.Drawing.Size(121, 19);
            this.mlblDimensiune.TabIndex = 57;
            this.mlblDimensiune.Text = "Dimensiune Colet ";
            // 
            // mlblGreutate
            // 
            this.mlblGreutate.AutoSize = true;
            this.mlblGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblGreutate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblGreutate.Location = new System.Drawing.Point(16, 602);
            this.mlblGreutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblGreutate.Name = "mlblGreutate";
            this.mlblGreutate.Size = new System.Drawing.Size(103, 19);
            this.mlblGreutate.TabIndex = 56;
            this.mlblGreutate.Text = "Greutate Colet ";
            // 
            // mlblDescriere
            // 
            this.mlblDescriere.AutoSize = true;
            this.mlblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDescriere.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDescriere.Location = new System.Drawing.Point(12, 548);
            this.mlblDescriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblDescriere.Name = "mlblDescriere";
            this.mlblDescriere.Size = new System.Drawing.Size(101, 19);
            this.mlblDescriere.TabIndex = 55;
            this.mlblDescriere.Text = "Descriere Colet";
            // 
            // mlblStareComanda
            // 
            this.mlblStareComanda.AutoSize = true;
            this.mlblStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblStareComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblStareComanda.Location = new System.Drawing.Point(12, 287);
            this.mlblStareComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblStareComanda.Name = "mlblStareComanda";
            this.mlblStareComanda.Size = new System.Drawing.Size(103, 19);
            this.mlblStareComanda.TabIndex = 54;
            this.mlblStareComanda.Text = "Stare Comanda";
            // 
            // mlblDataLivrare
            // 
            this.mlblDataLivrare.AutoSize = true;
            this.mlblDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDataLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblDataLivrare.Location = new System.Drawing.Point(12, 221);
            this.mlblDataLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblDataLivrare.Name = "mlblDataLivrare";
            this.mlblDataLivrare.Size = new System.Drawing.Size(83, 19);
            this.mlblDataLivrare.TabIndex = 53;
            this.mlblDataLivrare.Text = "Data Livrare";
            // 
            // mlblAdresaLivrare
            // 
            this.mlblAdresaLivrare.AutoSize = true;
            this.mlblAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblAdresaLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblAdresaLivrare.Location = new System.Drawing.Point(12, 171);
            this.mlblAdresaLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblAdresaLivrare.Name = "mlblAdresaLivrare";
            this.mlblAdresaLivrare.Size = new System.Drawing.Size(96, 19);
            this.mlblAdresaLivrare.TabIndex = 52;
            this.mlblAdresaLivrare.Text = "Adresa Livrare";
            // 
            // mlblNumeClient
            // 
            this.mlblNumeClient.AutoSize = true;
            this.mlblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblNumeClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblNumeClient.Location = new System.Drawing.Point(12, 119);
            this.mlblNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblNumeClient.Name = "mlblNumeClient";
            this.mlblNumeClient.Size = new System.Drawing.Size(85, 19);
            this.mlblNumeClient.TabIndex = 51;
            this.mlblNumeClient.Text = "Nume Client";
            // 
            // mlblIDComanda
            // 
            this.mlblIDComanda.AutoSize = true;
            this.mlblIDComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblIDComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblIDComanda.Location = new System.Drawing.Point(978, 60);
            this.mlblIDComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblIDComanda.Name = "mlblIDComanda";
            this.mlblIDComanda.Size = new System.Drawing.Size(86, 19);
            this.mlblIDComanda.TabIndex = 76;
            this.mlblIDComanda.Text = "ID Comanda";
            this.mlblIDComanda.Visible = false;
            // 
            // mlblIDColet
            // 
            this.mlblIDColet.AutoSize = true;
            this.mlblIDColet.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblIDColet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mlblIDColet.Location = new System.Drawing.Point(1226, 60);
            this.mlblIDColet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblIDColet.Name = "mlblIDColet";
            this.mlblIDColet.Size = new System.Drawing.Size(59, 19);
            this.mlblIDColet.TabIndex = 77;
            this.mlblIDColet.Text = "ID Colet";
            this.mlblIDColet.Visible = false;
            // 
            // mCmbStareComanda
            // 
            this.mCmbStareComanda.FormattingEnabled = true;
            this.mCmbStareComanda.ItemHeight = 23;
            this.mCmbStareComanda.Location = new System.Drawing.Point(286, 277);
            this.mCmbStareComanda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.mCmbStareComanda.Name = "mCmbStareComanda";
            this.mCmbStareComanda.Size = new System.Drawing.Size(482, 29);
            this.mCmbStareComanda.TabIndex = 75;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pbModifica);
            this.pnlHeader.Location = new System.Drawing.Point(6, 15);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(544, 81);
            this.pnlHeader.TabIndex = 78;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeader.Location = new System.Drawing.Point(98, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(421, 36);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "MODIFICARE COMANDA SI COLET";
            // 
            // pbModifica
            // 
            this.pbModifica.Image = ((System.Drawing.Image)(resources.GetObject("pbModifica.Image")));
            this.pbModifica.Location = new System.Drawing.Point(6, 4);
            this.pbModifica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbModifica.Name = "pbModifica";
            this.pbModifica.Size = new System.Drawing.Size(80, 71);
            this.pbModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModifica.TabIndex = 20;
            this.pbModifica.TabStop = false;
            // 
            // pnlModifica
            // 
            this.pnlModifica.Controls.Add(this.btnModifica);
            this.pnlModifica.Location = new System.Drawing.Point(282, 917);
            this.pnlModifica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlModifica.Name = "pnlModifica";
            this.pnlModifica.Size = new System.Drawing.Size(486, 90);
            this.pnlModifica.TabIndex = 79;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Image = ((System.Drawing.Image)(resources.GetObject("btnModifica.Image")));
            this.btnModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifica.Location = new System.Drawing.Point(-40, -12);
            this.btnModifica.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Padding = new System.Windows.Forms.Padding(50, 0, 0, 25);
            this.btnModifica.Size = new System.Drawing.Size(556, 142);
            this.btnModifica.TabIndex = 21;
            this.btnModifica.Text = "               Modifica";
            this.btnModifica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            this.btnModifica.MouseEnter += new System.EventHandler(this.btnModifica_MouseEnter);
            this.btnModifica.MouseLeave += new System.EventHandler(this.btnModifica_MouseLeave);
            // 
            // dtpDataLivrare
            // 
            this.dtpDataLivrare.Location = new System.Drawing.Point(286, 221);
            this.dtpDataLivrare.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpDataLivrare.Name = "dtpDataLivrare";
            this.dtpDataLivrare.Size = new System.Drawing.Size(478, 31);
            this.dtpDataLivrare.TabIndex = 80;
            // 
            // FormaModificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1730, 1090);
            this.Controls.Add(this.dtpDataLivrare);
            this.Controls.Add(this.pnlModifica);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.mlblIDColet);
            this.Controls.Add(this.mlblIDComanda);
            this.Controls.Add(this.mCmbStareComanda);
            this.Controls.Add(this.gpbOptiuniLivrare);
            this.Controls.Add(this.mlblEroareOptiuniLivrare);
            this.Controls.Add(this.gpbDimensiuneColet);
            this.Controls.Add(this.mlblOptiuniLivrare);
            this.Controls.Add(this.nUDGreutate);
            this.Controls.Add(this.mlblEroareDimensiune);
            this.Controls.Add(this.mlblEroareGreutate);
            this.Controls.Add(this.mlblEroareDescriere);
            this.Controls.Add(this.mlblEroareStareComanda);
            this.Controls.Add(this.mlblEroareDataLivrare);
            this.Controls.Add(this.mlblEroareAdresaLivrare);
            this.Controls.Add(this.mlblEroareNumeClient);
            this.Controls.Add(this.mtxtDescriere);
            this.Controls.Add(this.mtxtAdresaLivrare);
            this.Controls.Add(this.mtxtNumeClient);
            this.Controls.Add(this.mlblDimensiune);
            this.Controls.Add(this.mlblGreutate);
            this.Controls.Add(this.mlblDescriere);
            this.Controls.Add(this.mlblStareComanda);
            this.Controls.Add(this.mlblDataLivrare);
            this.Controls.Add(this.mlblAdresaLivrare);
            this.Controls.Add(this.mlblNumeClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormaModificare";
            this.Padding = new System.Windows.Forms.Padding(40, 115, 40, 38);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.gpbOptiuniLivrare.ResumeLayout(false);
            this.gpbOptiuniLivrare.PerformLayout();
            this.gpbDimensiuneColet.ResumeLayout(false);
            this.gpbDimensiuneColet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGreutate)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModifica)).EndInit();
            this.pnlModifica.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbOptiuniLivrare;
        private MetroFramework.Controls.MetroLabel mlblEroareOptiuniLivrare;
        private System.Windows.Forms.GroupBox gpbDimensiuneColet;
        private MetroFramework.Controls.MetroLabel mlblOptiuniLivrare;
        private System.Windows.Forms.NumericUpDown nUDGreutate;
        private MetroFramework.Controls.MetroLabel mlblEroareDimensiune;
        private MetroFramework.Controls.MetroLabel mlblEroareGreutate;
        private MetroFramework.Controls.MetroLabel mlblEroareDescriere;
        private MetroFramework.Controls.MetroLabel mlblEroareStareComanda;
        private MetroFramework.Controls.MetroLabel mlblEroareDataLivrare;
        private MetroFramework.Controls.MetroLabel mlblEroareAdresaLivrare;
        private MetroFramework.Controls.MetroLabel mlblEroareNumeClient;
        private MetroFramework.Controls.MetroTextBox mtxtDescriere;
        private MetroFramework.Controls.MetroTextBox mtxtAdresaLivrare;
        private MetroFramework.Controls.MetroTextBox mtxtNumeClient;
        private MetroFramework.Controls.MetroLabel mlblDimensiune;
        private MetroFramework.Controls.MetroLabel mlblGreutate;
        private MetroFramework.Controls.MetroLabel mlblDescriere;
        private MetroFramework.Controls.MetroLabel mlblStareComanda;
        private MetroFramework.Controls.MetroLabel mlblDataLivrare;
        private MetroFramework.Controls.MetroLabel mlblAdresaLivrare;
        private MetroFramework.Controls.MetroLabel mlblNumeClient;
        private MetroFramework.Controls.MetroLabel mlblIDComanda;
        private System.Windows.Forms.CheckBox ckbFragil;
        private System.Windows.Forms.CheckBox ckbPerisabil;
        private System.Windows.Forms.CheckBox ckbLivrareRapida;
        private System.Windows.Forms.CheckBox ckbAsigurareColet;
        private System.Windows.Forms.CheckBox ckbLivrareSambata;
        private System.Windows.Forms.CheckBox ckbLivrareDuminica;
        private System.Windows.Forms.RadioButton rdbExtraMare;
        private System.Windows.Forms.RadioButton rdbMic;
        private System.Windows.Forms.RadioButton rdbMareMare;
        private System.Windows.Forms.RadioButton rdbMediuMic;
        private System.Windows.Forms.RadioButton rdbMareStandard;
        private System.Windows.Forms.RadioButton rdbMediuStandard;
        private System.Windows.Forms.RadioButton rdbMareMica;
        private System.Windows.Forms.RadioButton rdbMediuMare;
        private MetroFramework.Controls.MetroLabel mlblIDColet;
        private MetroFramework.Controls.MetroComboBox mCmbStareComanda;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbModifica;
        private System.Windows.Forms.Panel pnlModifica;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DateTimePicker dtpDataLivrare;
    }
}