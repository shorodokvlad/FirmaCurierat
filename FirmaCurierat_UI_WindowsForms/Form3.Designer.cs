using MetroFramework.Controls;

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
            this.buttonCautaComanda = new MetroFramework.Controls.MetroButton();
            this.lblIDComanda = new MetroFramework.Controls.MetroLabel();
            this.txtIDComanda = new MetroFramework.Controls.MetroTextBox();
            this.txtNumeClient = new MetroFramework.Controls.MetroTextBox();
            this.lblNumeClient = new MetroFramework.Controls.MetroLabel();
            this.txtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.lblDescriere = new MetroFramework.Controls.MetroLabel();
            this.txtIDColet = new MetroFramework.Controls.MetroTextBox();
            this.lblIDColet = new MetroFramework.Controls.MetroLabel();
            this.buttonCautaColet = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // buttonCautaComanda
            // 
            this.buttonCautaComanda.Location = new System.Drawing.Point(276, 365);
            this.buttonCautaComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCautaComanda.Name = "buttonCautaComanda";
            this.buttonCautaComanda.Size = new System.Drawing.Size(240, 48);
            this.buttonCautaComanda.TabIndex = 0;
            this.buttonCautaComanda.Text = "Cauta Comanda";
            this.buttonCautaComanda.Click += new System.EventHandler(this.buttonCautaComanda_Click);
            // 
            // lblIDComanda
            // 
            this.lblIDComanda.AutoSize = true;
            this.lblIDComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIDComanda.Location = new System.Drawing.Point(96, 202);
            this.lblIDComanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDComanda.Name = "lblIDComanda";
            this.lblIDComanda.Size = new System.Drawing.Size(86, 19);
            this.lblIDComanda.TabIndex = 1;
            this.lblIDComanda.Text = "ID Comanda";
            // 
            // txtIDComanda
            // 
            this.txtIDComanda.Location = new System.Drawing.Point(276, 200);
            this.txtIDComanda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDComanda.Name = "txtIDComanda";
            this.txtIDComanda.Size = new System.Drawing.Size(244, 38);
            this.txtIDComanda.TabIndex = 2;
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(276, 265);
            this.txtNumeClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(244, 38);
            this.txtNumeClient.TabIndex = 4;
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNumeClient.Location = new System.Drawing.Point(96, 265);
            this.lblNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(85, 19);
            this.lblNumeClient.TabIndex = 3;
            this.lblNumeClient.Text = "Nume Client";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(908, 265);
            this.txtDescriere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(244, 38);
            this.txtDescriere.TabIndex = 9;
            // 
            // lblDescriere
            // 
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDescriere.Location = new System.Drawing.Point(742, 269);
            this.lblDescriere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriere.Name = "lblDescriere";
            this.lblDescriere.Size = new System.Drawing.Size(69, 19);
            this.lblDescriere.TabIndex = 8;
            this.lblDescriere.Text = "Descriere ";
            // 
            // txtIDColet
            // 
            this.txtIDColet.Location = new System.Drawing.Point(908, 202);
            this.txtIDColet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDColet.Name = "txtIDColet";
            this.txtIDColet.Size = new System.Drawing.Size(244, 38);
            this.txtIDColet.TabIndex = 7;
            // 
            // lblIDColet
            // 
            this.lblIDColet.AutoSize = true;
            this.lblIDColet.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIDColet.Location = new System.Drawing.Point(742, 204);
            this.lblIDColet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDColet.Name = "lblIDColet";
            this.lblIDColet.Size = new System.Drawing.Size(59, 19);
            this.lblIDColet.TabIndex = 6;
            this.lblIDColet.Text = "ID Colet";
            // 
            // buttonCautaColet
            // 
            this.buttonCautaColet.Location = new System.Drawing.Point(908, 365);
            this.buttonCautaColet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCautaColet.Name = "buttonCautaColet";
            this.buttonCautaColet.Size = new System.Drawing.Size(240, 48);
            this.buttonCautaColet.TabIndex = 5;
            this.buttonCautaColet.Text = "Cauta Colet";
            this.buttonCautaColet.Click += new System.EventHandler(this.buttonCautaColet_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 1090);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(20, 115, 20, 19);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cautare comanda sau colet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroButton buttonCautaComanda;
        private MetroTextBox txtIDComanda;
        private MetroLabel lblIDComanda;
        private MetroTextBox txtNumeClient;
        private MetroLabel lblNumeClient;
        private MetroTextBox txtDescriere;
        private MetroLabel lblDescriere;
        private MetroTextBox txtIDColet;
        private MetroLabel lblIDColet;
        private MetroButton buttonCautaColet;
    }
}