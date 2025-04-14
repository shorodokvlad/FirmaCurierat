namespace FirmaCurierat_UI_WindowsForms
{
    partial class Form3
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
            this.buttonCautaComanda = new System.Windows.Forms.Button();
            this.lblIDComanda = new System.Windows.Forms.Label();
            this.txtIDComanda = new System.Windows.Forms.TextBox();
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.txtIDColet = new System.Windows.Forms.TextBox();
            this.lblIDColet = new System.Windows.Forms.Label();
            this.buttonCautaColet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCautaComanda
            // 
            this.buttonCautaComanda.Location = new System.Drawing.Point(261, 366);
            this.buttonCautaComanda.Name = "buttonCautaComanda";
            this.buttonCautaComanda.Size = new System.Drawing.Size(239, 48);
            this.buttonCautaComanda.TabIndex = 0;
            this.buttonCautaComanda.Text = "Cauta Comanda";
            this.buttonCautaComanda.UseVisualStyleBackColor = true;
            this.buttonCautaComanda.Click += new System.EventHandler(this.buttonCautaComanda_Click);
            // 
            // lblIDComanda
            // 
            this.lblIDComanda.AutoSize = true;
            this.lblIDComanda.Location = new System.Drawing.Point(96, 201);
            this.lblIDComanda.Name = "lblIDComanda";
            this.lblIDComanda.Size = new System.Drawing.Size(130, 25);
            this.lblIDComanda.TabIndex = 1;
            this.lblIDComanda.Text = "ID Comanda";
            // 
            // txtIDComanda
            // 
            this.txtIDComanda.Location = new System.Drawing.Point(261, 195);
            this.txtIDComanda.Name = "txtIDComanda";
            this.txtIDComanda.Size = new System.Drawing.Size(239, 31);
            this.txtIDComanda.TabIndex = 2;
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(261, 260);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(239, 31);
            this.txtNumeClient.TabIndex = 4;
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.Location = new System.Drawing.Point(96, 266);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(129, 25);
            this.lblNumeClient.TabIndex = 3;
            this.lblNumeClient.Text = "Nume Client";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(872, 266);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(239, 31);
            this.txtDescriere.TabIndex = 9;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(706, 269);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(110, 25);
            this.lblDescriere.TabIndex = 8;
            this.lblDescriere.Text = "Descriere ";
            // 
            // txtIDColet
            // 
            this.txtIDColet.Location = new System.Drawing.Point(872, 201);
            this.txtIDColet.Name = "txtIDColet";
            this.txtIDColet.Size = new System.Drawing.Size(239, 31);
            this.txtIDColet.TabIndex = 7;
            // 
            // lblIDColet
            // 
            this.lblIDColet.AutoSize = true;
            this.lblIDColet.Location = new System.Drawing.Point(706, 204);
            this.lblIDColet.Name = "lblIDColet";
            this.lblIDColet.Size = new System.Drawing.Size(88, 25);
            this.lblIDColet.TabIndex = 6;
            this.lblIDColet.Text = "ID Colet";
            // 
            // buttonCautaColet
            // 
            this.buttonCautaColet.Location = new System.Drawing.Point(872, 366);
            this.buttonCautaColet.Name = "buttonCautaColet";
            this.buttonCautaColet.Size = new System.Drawing.Size(239, 48);
            this.buttonCautaColet.TabIndex = 5;
            this.buttonCautaColet.Text = "Cauta Colet";
            this.buttonCautaColet.UseVisualStyleBackColor = true;
            this.buttonCautaColet.Click += new System.EventHandler(this.buttonCautaColet_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 1091);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.txtIDColet);
            this.Controls.Add(this.lblIDColet);
            this.Controls.Add(this.buttonCautaColet);
            this.Controls.Add(this.txtNumeClient);
            this.Controls.Add(this.lblNumeClient);
            this.Controls.Add(this.txtIDComanda);
            this.Controls.Add(this.lblIDComanda);
            this.Controls.Add(this.buttonCautaComanda);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCautaComanda;
        private System.Windows.Forms.Label lblIDComanda;
        private System.Windows.Forms.TextBox txtIDComanda;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.TextBox txtIDColet;
        private System.Windows.Forms.Label lblIDColet;
        private System.Windows.Forms.Button buttonCautaColet;
    }
}