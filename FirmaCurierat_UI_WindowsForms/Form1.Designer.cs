namespace FirmaCurierat_UI_WindowsForms
{
    partial class Form1
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
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttoCautare = new System.Windows.Forms.Button();
            this.lblIDComanda = new System.Windows.Forms.Label();
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.lblAdresaLivrare = new System.Windows.Forms.Label();
            this.lblIDColet = new System.Windows.Forms.Label();
            this.lblStareComanda = new System.Windows.Forms.Label();
            this.lblDataLivrare = new System.Windows.Forms.Label();
            this.lblDimensiune = new System.Windows.Forms.Label();
            this.lblGreutate = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(48, 71);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(141, 52);
            this.buttonAdauga.TabIndex = 0;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(48, 161);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(141, 52);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttoCautare
            // 
            this.buttoCautare.Location = new System.Drawing.Point(48, 242);
            this.buttoCautare.Name = "buttoCautare";
            this.buttoCautare.Size = new System.Drawing.Size(141, 52);
            this.buttoCautare.TabIndex = 2;
            this.buttoCautare.Text = "Cautare";
            this.buttoCautare.UseVisualStyleBackColor = true;
            this.buttoCautare.Click += new System.EventHandler(this.buttoCautare_Click);
            // 
            // lblIDComanda
            // 
            this.lblIDComanda.AutoSize = true;
            this.lblIDComanda.BackColor = System.Drawing.SystemColors.Control;
            this.lblIDComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIDComanda.Location = new System.Drawing.Point(274, 21);
            this.lblIDComanda.Name = "lblIDComanda";
            this.lblIDComanda.Size = new System.Drawing.Size(130, 25);
            this.lblIDComanda.TabIndex = 3;
            this.lblIDComanda.Text = "ID Comanda";
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumeClient.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumeClient.Location = new System.Drawing.Point(552, 21);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(129, 25);
            this.lblNumeClient.TabIndex = 4;
            this.lblNumeClient.Text = "Nume Client";
            // 
            // lblAdresaLivrare
            // 
            this.lblAdresaLivrare.AutoSize = true;
            this.lblAdresaLivrare.BackColor = System.Drawing.SystemColors.Control;
            this.lblAdresaLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblAdresaLivrare.Location = new System.Drawing.Point(820, 21);
            this.lblAdresaLivrare.Name = "lblAdresaLivrare";
            this.lblAdresaLivrare.Size = new System.Drawing.Size(152, 25);
            this.lblAdresaLivrare.TabIndex = 5;
            this.lblAdresaLivrare.Text = "Adresa Livrare";
            // 
            // lblIDColet
            // 
            this.lblIDColet.AutoSize = true;
            this.lblIDColet.BackColor = System.Drawing.SystemColors.Control;
            this.lblIDColet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblIDColet.Location = new System.Drawing.Point(1645, 21);
            this.lblIDColet.Name = "lblIDColet";
            this.lblIDColet.Size = new System.Drawing.Size(88, 25);
            this.lblIDColet.TabIndex = 8;
            this.lblIDColet.Text = "ID Colet";
            // 
            // lblStareComanda
            // 
            this.lblStareComanda.AutoSize = true;
            this.lblStareComanda.BackColor = System.Drawing.SystemColors.Control;
            this.lblStareComanda.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblStareComanda.Location = new System.Drawing.Point(1370, 21);
            this.lblStareComanda.Name = "lblStareComanda";
            this.lblStareComanda.Size = new System.Drawing.Size(161, 25);
            this.lblStareComanda.TabIndex = 7;
            this.lblStareComanda.Text = "Stare Comanda";
            // 
            // lblDataLivrare
            // 
            this.lblDataLivrare.AutoSize = true;
            this.lblDataLivrare.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataLivrare.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDataLivrare.Location = new System.Drawing.Point(1095, 21);
            this.lblDataLivrare.Name = "lblDataLivrare";
            this.lblDataLivrare.Size = new System.Drawing.Size(129, 25);
            this.lblDataLivrare.TabIndex = 6;
            this.lblDataLivrare.Text = "Data Livrare";
            // 
            // lblDimensiune
            // 
            this.lblDimensiune.AutoSize = true;
            this.lblDimensiune.BackColor = System.Drawing.SystemColors.Control;
            this.lblDimensiune.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDimensiune.Location = new System.Drawing.Point(2465, 21);
            this.lblDimensiune.Name = "lblDimensiune";
            this.lblDimensiune.Size = new System.Drawing.Size(181, 25);
            this.lblDimensiune.TabIndex = 11;
            this.lblDimensiune.Text = "Dimensiune Colet";
            // 
            // lblGreutate
            // 
            this.lblGreutate.AutoSize = true;
            this.lblGreutate.BackColor = System.Drawing.SystemColors.Control;
            this.lblGreutate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGreutate.Location = new System.Drawing.Point(2190, 21);
            this.lblGreutate.Name = "lblGreutate";
            this.lblGreutate.Size = new System.Drawing.Size(192, 25);
            this.lblGreutate.TabIndex = 10;
            this.lblGreutate.Text = "Greutate Colet [kg]";
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescriere.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescriere.Location = new System.Drawing.Point(1922, 21);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(160, 25);
            this.lblDescriere.TabIndex = 9;
            this.lblDescriere.Text = "Descriere Colet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3337, 1044);
            this.Controls.Add(this.lblDimensiune);
            this.Controls.Add(this.lblGreutate);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.lblIDColet);
            this.Controls.Add(this.lblStareComanda);
            this.Controls.Add(this.lblDataLivrare);
            this.Controls.Add(this.lblAdresaLivrare);
            this.Controls.Add(this.lblNumeClient);
            this.Controls.Add(this.lblIDComanda);
            this.Controls.Add(this.buttoCautare);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdauga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttoCautare;
        private System.Windows.Forms.Label lblIDComanda;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.Label lblAdresaLivrare;
        private System.Windows.Forms.Label lblIDColet;
        private System.Windows.Forms.Label lblStareComanda;
        private System.Windows.Forms.Label lblDataLivrare;
        private System.Windows.Forms.Label lblDimensiune;
        private System.Windows.Forms.Label lblGreutate;
        private System.Windows.Forms.Label lblDescriere;
    }
}

