using MetroFramework.Controls;

namespace FirmaCurierat_UI_WindowsForms
{
    partial class FormaCautareComanda
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
            this.mlblIDComanda = new MetroFramework.Controls.MetroLabel();
            this.mtxtIDComanda = new MetroFramework.Controls.MetroTextBox();
            this.mtxtNumeClient = new MetroFramework.Controls.MetroTextBox();
            this.mlblNumeClient = new MetroFramework.Controls.MetroLabel();
            this.mtCautaDupaIDComanda = new MetroFramework.Controls.MetroTile();
            this.mtCautaDupaNumeClient = new MetroFramework.Controls.MetroTile();
            this.mlblEroareIDComanda = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareNumeClient = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlblIDComanda
            // 
            this.mlblIDComanda.AutoSize = true;
            this.mlblIDComanda.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblIDComanda.Location = new System.Drawing.Point(38, 74);
            this.mlblIDComanda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblIDComanda.Name = "mlblIDComanda";
            this.mlblIDComanda.Size = new System.Drawing.Size(86, 19);
            this.mlblIDComanda.TabIndex = 1;
            this.mlblIDComanda.Text = "ID Comanda";
            // 
            // mtxtIDComanda
            // 
            this.mtxtIDComanda.Location = new System.Drawing.Point(128, 73);
            this.mtxtIDComanda.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtIDComanda.Name = "mtxtIDComanda";
            this.mtxtIDComanda.Size = new System.Drawing.Size(147, 20);
            this.mtxtIDComanda.TabIndex = 2;
            // 
            // mtxtNumeClient
            // 
            this.mtxtNumeClient.Location = new System.Drawing.Point(128, 131);
            this.mtxtNumeClient.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtNumeClient.Name = "mtxtNumeClient";
            this.mtxtNumeClient.Size = new System.Drawing.Size(147, 20);
            this.mtxtNumeClient.TabIndex = 4;
            // 
            // mlblNumeClient
            // 
            this.mlblNumeClient.AutoSize = true;
            this.mlblNumeClient.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblNumeClient.Location = new System.Drawing.Point(38, 131);
            this.mlblNumeClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblNumeClient.Name = "mlblNumeClient";
            this.mlblNumeClient.Size = new System.Drawing.Size(85, 19);
            this.mlblNumeClient.TabIndex = 3;
            this.mlblNumeClient.Text = "Nume Client";
            // 
            // mtCautaDupaIDComanda
            // 
            this.mtCautaDupaIDComanda.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautaDupaIDComanda.CustomBackground = true;
            this.mtCautaDupaIDComanda.Location = new System.Drawing.Point(307, 74);
            this.mtCautaDupaIDComanda.Name = "mtCautaDupaIDComanda";
            this.mtCautaDupaIDComanda.Size = new System.Drawing.Size(107, 19);
            this.mtCautaDupaIDComanda.TabIndex = 8;
            this.mtCautaDupaIDComanda.Text = "Cauta ";
            this.mtCautaDupaIDComanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautaDupaIDComanda.Click += new System.EventHandler(this.mtCautaDupaIDComanda_Click);
            // 
            // mtCautaDupaNumeClient
            // 
            this.mtCautaDupaNumeClient.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautaDupaNumeClient.CustomBackground = true;
            this.mtCautaDupaNumeClient.Location = new System.Drawing.Point(307, 130);
            this.mtCautaDupaNumeClient.Name = "mtCautaDupaNumeClient";
            this.mtCautaDupaNumeClient.Size = new System.Drawing.Size(107, 20);
            this.mtCautaDupaNumeClient.TabIndex = 9;
            this.mtCautaDupaNumeClient.Text = "Cauta ";
            this.mtCautaDupaNumeClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautaDupaNumeClient.Click += new System.EventHandler(this.mtCautaDupaNumeClient_Click);
            // 
            // mlblEroareIDComanda
            // 
            this.mlblEroareIDComanda.AutoSize = true;
            this.mlblEroareIDComanda.CustomForeColor = true;
            this.mlblEroareIDComanda.ForeColor = System.Drawing.Color.Red;
            this.mlblEroareIDComanda.Location = new System.Drawing.Point(128, 99);
            this.mlblEroareIDComanda.Name = "mlblEroareIDComanda";
            this.mlblEroareIDComanda.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareIDComanda.TabIndex = 10;
            // 
            // mlblEroareNumeClient
            // 
            this.mlblEroareNumeClient.AutoSize = true;
            this.mlblEroareNumeClient.CustomForeColor = true;
            this.mlblEroareNumeClient.ForeColor = System.Drawing.Color.Red;
            this.mlblEroareNumeClient.Location = new System.Drawing.Point(128, 153);
            this.mlblEroareNumeClient.Name = "mlblEroareNumeClient";
            this.mlblEroareNumeClient.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareNumeClient.TabIndex = 11;
            // 
            // FormaCautareComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 567);
            this.Controls.Add(this.mlblEroareNumeClient);
            this.Controls.Add(this.mlblEroareIDComanda);
            this.Controls.Add(this.mtCautaDupaNumeClient);
            this.Controls.Add(this.mtCautaDupaIDComanda);
            this.Controls.Add(this.mtxtNumeClient);
            this.Controls.Add(this.mlblNumeClient);
            this.Controls.Add(this.mtxtIDComanda);
            this.Controls.Add(this.mlblIDComanda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaCautareComanda";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cautare comanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroTextBox mtxtIDComanda;
        private MetroLabel mlblIDComanda;
        private MetroTextBox mtxtNumeClient;
        private MetroLabel mlblNumeClient;
        private MetroTile mtCautaDupaIDComanda;
        private MetroTile mtCautaDupaNumeClient;
        private MetroLabel mlblEroareIDComanda;
        private MetroLabel mlblEroareNumeClient;
    }
}