using MetroFramework.Controls;

namespace FirmaCurierat_UI_WindowsForms
{
    partial class Form2
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
            this.lblNumeClient = new MetroFramework.Controls.MetroLabel();
            this.lblAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.lblDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.lblStareComanda = new MetroFramework.Controls.MetroLabel();
            this.lblDescriere = new MetroFramework.Controls.MetroLabel();
            this.lblGreutate = new MetroFramework.Controls.MetroLabel();
            this.lblDimensiune = new MetroFramework.Controls.MetroLabel();
            this.txtNumeClient = new MetroFramework.Controls.MetroTextBox();
            this.txtAdresaLivrare = new MetroFramework.Controls.MetroTextBox();
            this.txtDataLivrare = new MetroFramework.Controls.MetroTextBox();
            this.txtStareComanda = new MetroFramework.Controls.MetroTextBox();
            this.txtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.txtGreutate = new MetroFramework.Controls.MetroTextBox();
            this.txtDimensiune = new MetroFramework.Controls.MetroTextBox();
            this.txtEroareNumeClient = new MetroFramework.Controls.MetroLabel();
            this.txtEroareAdresaLivrare = new MetroFramework.Controls.MetroLabel();
            this.txtEroareDataLivrare = new MetroFramework.Controls.MetroLabel();
            this.txtEroareStareComanda = new MetroFramework.Controls.MetroLabel();
            this.txtEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.txtEroareGreutate = new MetroFramework.Controls.MetroLabel();
            this.txtEroareDimensiune = new MetroFramework.Controls.MetroLabel();
            this.mtSalveaza = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumeClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumeClient.Location = new System.Drawing.Point(122, 235);
            this.lblNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(85, 19);
            this.lblNumeClient.TabIndex = 0;
            this.lblNumeClient.Text = "Nume Client";
            // 
            // lblAdresaLivrare
            // 
            this.lblAdresaLivrare.AutoSize = true;
            this.lblAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdresaLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdresaLivrare.Location = new System.Drawing.Point(122, 287);
            this.lblAdresaLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresaLivrare.Name = "lblAdresaLivrare";
            this.lblAdresaLivrare.Size = new System.Drawing.Size(96, 19);
            this.lblAdresaLivrare.TabIndex = 1;
            this.lblAdresaLivrare.Text = "Adresa Livrare";
            // 
            // lblDataLivrare
            // 
            this.lblDataLivrare.AutoSize = true;
            this.lblDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDataLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDataLivrare.Location = new System.Drawing.Point(122, 337);
            this.lblDataLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLivrare.Name = "lblDataLivrare";
            this.lblDataLivrare.Size = new System.Drawing.Size(83, 19);
            this.lblDataLivrare.TabIndex = 3;
            this.lblDataLivrare.Text = "Data Livrare";
            // 
            // lblStareComanda
            // 
            this.lblStareComanda.AutoSize = true;
            this.lblStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblStareComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStareComanda.Location = new System.Drawing.Point(122, 388);
            this.lblStareComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStareComanda.Name = "lblStareComanda";
            this.lblStareComanda.Size = new System.Drawing.Size(103, 19);
            this.lblStareComanda.TabIndex = 4;
            this.lblStareComanda.Text = "Stare Comanda";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescriere.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescriere.Location = new System.Drawing.Point(122, 442);
            this.lblDescriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(101, 19);
            this.lblDescriere.TabIndex = 6;
            this.lblDescriere.Text = "Descriere Colet";
            // 
            // lblGreutate
            // 
            this.lblGreutate.AutoSize = true;
            this.lblGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblGreutate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGreutate.Location = new System.Drawing.Point(124, 496);
            this.lblGreutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(103, 19);
            this.lblGreutate.TabIndex = 7;
            this.lblGreutate.Text = "Greutate Colet ";
            // 
            // lblDimensiune
            // 
            this.lblDimensiune.AutoSize = true;
            this.lblDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDimensiune.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDimensiune.Location = new System.Drawing.Point(122, 554);
            this.lblDimensiune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDimensiune.Name = "lblDimensiune";
            this.lblDimensiune.Size = new System.Drawing.Size(121, 19);
            this.lblDimensiune.TabIndex = 8;
            this.lblDimensiune.Text = "Dimensiune Colet ";
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumeClient.Location = new System.Drawing.Point(397, 235);
            this.txtNumeClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(377, 31);
            this.txtNumeClient.TabIndex = 10;
            // 
            // txtAdresaLivrare
            // 
            this.txtAdresaLivrare.Location = new System.Drawing.Point(397, 287);
            this.txtAdresaLivrare.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresaLivrare.Name = "txtAdresaLivrare";
            this.txtAdresaLivrare.Size = new System.Drawing.Size(377, 31);
            this.txtAdresaLivrare.TabIndex = 11;
            // 
            // txtDataLivrare
            // 
            this.txtDataLivrare.Location = new System.Drawing.Point(397, 337);
            this.txtDataLivrare.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataLivrare.Name = "txtDataLivrare";
            this.txtDataLivrare.Size = new System.Drawing.Size(377, 31);
            this.txtDataLivrare.TabIndex = 12;
            // 
            // txtStareComanda
            // 
            this.txtStareComanda.Location = new System.Drawing.Point(397, 388);
            this.txtStareComanda.Margin = new System.Windows.Forms.Padding(4);
            this.txtStareComanda.Name = "txtStareComanda";
            this.txtStareComanda.Size = new System.Drawing.Size(377, 31);
            this.txtStareComanda.TabIndex = 13;
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(397, 442);
            this.txtDescriere.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(377, 31);
            this.txtDescriere.TabIndex = 15;
            // 
            // txtGreutate
            // 
            this.txtGreutate.Location = new System.Drawing.Point(397, 496);
            this.txtGreutate.Margin = new System.Windows.Forms.Padding(4);
            this.txtGreutate.Name = "txtGreutate";
            this.txtGreutate.Size = new System.Drawing.Size(377, 31);
            this.txtGreutate.TabIndex = 16;
            // 
            // txtDimensiune
            // 
            this.txtDimensiune.Location = new System.Drawing.Point(397, 554);
            this.txtDimensiune.Margin = new System.Windows.Forms.Padding(4);
            this.txtDimensiune.Name = "txtDimensiune";
            this.txtDimensiune.Size = new System.Drawing.Size(377, 31);
            this.txtDimensiune.TabIndex = 17;
            // 
            // txtEroareNumeClient
            // 
            this.txtEroareNumeClient.AutoSize = true;
            this.txtEroareNumeClient.CustomForeColor = true;
            this.txtEroareNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareNumeClient.Location = new System.Drawing.Point(856, 256);
            this.txtEroareNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareNumeClient.Name = "txtEroareNumeClient";
            this.txtEroareNumeClient.Size = new System.Drawing.Size(0, 0);
            this.txtEroareNumeClient.TabIndex = 19;
            // 
            // txtEroareAdresaLivrare
            // 
            this.txtEroareAdresaLivrare.AutoSize = true;
            this.txtEroareAdresaLivrare.CustomForeColor = true;
            this.txtEroareAdresaLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareAdresaLivrare.Location = new System.Drawing.Point(857, 308);
            this.txtEroareAdresaLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareAdresaLivrare.Name = "txtEroareAdresaLivrare";
            this.txtEroareAdresaLivrare.Size = new System.Drawing.Size(0, 0);
            this.txtEroareAdresaLivrare.TabIndex = 20;
            // 
            // txtEroareDataLivrare
            // 
            this.txtEroareDataLivrare.AutoSize = true;
            this.txtEroareDataLivrare.CustomForeColor = true;
            this.txtEroareDataLivrare.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareDataLivrare.Location = new System.Drawing.Point(856, 358);
            this.txtEroareDataLivrare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareDataLivrare.Name = "txtEroareDataLivrare";
            this.txtEroareDataLivrare.Size = new System.Drawing.Size(0, 0);
            this.txtEroareDataLivrare.TabIndex = 21;
            // 
            // txtEroareStareComanda
            // 
            this.txtEroareStareComanda.AutoSize = true;
            this.txtEroareStareComanda.CustomForeColor = true;
            this.txtEroareStareComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareStareComanda.Location = new System.Drawing.Point(856, 409);
            this.txtEroareStareComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareStareComanda.Name = "txtEroareStareComanda";
            this.txtEroareStareComanda.Size = new System.Drawing.Size(0, 0);
            this.txtEroareStareComanda.TabIndex = 22;
            // 
            // txtEroareDescriere
            // 
            this.txtEroareDescriere.AutoSize = true;
            this.txtEroareDescriere.CustomForeColor = true;
            this.txtEroareDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareDescriere.Location = new System.Drawing.Point(856, 456);
            this.txtEroareDescriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareDescriere.Name = "txtEroareDescriere";
            this.txtEroareDescriere.Size = new System.Drawing.Size(0, 0);
            this.txtEroareDescriere.TabIndex = 24;
            // 
            // txtEroareGreutate
            // 
            this.txtEroareGreutate.AutoSize = true;
            this.txtEroareGreutate.CustomForeColor = true;
            this.txtEroareGreutate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareGreutate.Location = new System.Drawing.Point(856, 509);
            this.txtEroareGreutate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareGreutate.Name = "txtEroareGreutate";
            this.txtEroareGreutate.Size = new System.Drawing.Size(0, 0);
            this.txtEroareGreutate.TabIndex = 25;
            // 
            // txtEroareDimensiune
            // 
            this.txtEroareDimensiune.AutoSize = true;
            this.txtEroareDimensiune.CustomForeColor = true;
            this.txtEroareDimensiune.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtEroareDimensiune.Location = new System.Drawing.Point(857, 554);
            this.txtEroareDimensiune.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtEroareDimensiune.Name = "txtEroareDimensiune";
            this.txtEroareDimensiune.Size = new System.Drawing.Size(0, 0);
            this.txtEroareDimensiune.TabIndex = 26;
            // 
            // mtSalveaza
            // 
            this.mtSalveaza.BackColor = System.Drawing.Color.LightSlateGray;
            this.mtSalveaza.CustomBackground = true;
            this.mtSalveaza.Location = new System.Drawing.Point(397, 637);
            this.mtSalveaza.Name = "mtSalveaza";
            this.mtSalveaza.Size = new System.Drawing.Size(377, 85);
            this.mtSalveaza.TabIndex = 28;
            this.mtSalveaza.Text = "Salveaza";
            this.mtSalveaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSalveaza.Click += new System.EventHandler(this.mtSalveaza_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1730, 1090);
            this.Controls.Add(this.mtSalveaza);
            this.Controls.Add(this.txtEroareDimensiune);
            this.Controls.Add(this.txtEroareGreutate);
            this.Controls.Add(this.txtEroareDescriere);
            this.Controls.Add(this.txtEroareStareComanda);
            this.Controls.Add(this.txtEroareDataLivrare);
            this.Controls.Add(this.txtEroareAdresaLivrare);
            this.Controls.Add(this.txtEroareNumeClient);
            this.Controls.Add(this.txtDimensiune);
            this.Controls.Add(this.txtGreutate);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.txtStareComanda);
            this.Controls.Add(this.txtDataLivrare);
            this.Controls.Add(this.txtAdresaLivrare);
            this.Controls.Add(this.txtNumeClient);
            this.Controls.Add(this.lblDimensiune);
            this.Controls.Add(this.lblGreutate);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblStareComanda);
            this.Controls.Add(this.lblDataLivrare);
            this.Controls.Add(this.lblAdresaLivrare);
            this.Controls.Add(this.lblNumeClient);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(20, 115, 20, 19);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Adaugare comanda si colet";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private MetroLabel lblNumeClient;
        private MetroLabel lblAdresaLivrare;
        private MetroLabel lblDataLivrare;
        private MetroLabel lblStareComanda;
        private MetroLabel lblDescriere;
        private MetroLabel lblGreutate;
        private MetroLabel lblDimensiune;
        private MetroTextBox txtNumeClient;
        private MetroTextBox txtAdresaLivrare;
        private MetroTextBox txtDataLivrare;
        private MetroTextBox txtStareComanda;
        private MetroTextBox txtDescriere;
        private MetroTextBox txtGreutate;
        private MetroTextBox txtDimensiune;
        private MetroLabel txtEroareNumeClient;
        private MetroLabel txtEroareAdresaLivrare;
        private MetroLabel txtEroareDataLivrare;
        private MetroLabel txtEroareStareComanda;
        private MetroLabel txtEroareDescriere;
        private MetroLabel txtEroareGreutate;
        private MetroLabel txtEroareDimensiune;
        private MetroTile mtSalveaza;
    }
}