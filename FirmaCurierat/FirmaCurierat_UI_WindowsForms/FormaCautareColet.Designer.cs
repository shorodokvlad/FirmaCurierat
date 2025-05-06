namespace FirmaCurierat_UI_WindowsForms
{
    partial class FormCautareColet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCautareColet));
            this.mtxtDescriere = new MetroFramework.Controls.MetroTextBox();
            this.mlblDescriere = new MetroFramework.Controls.MetroLabel();
            this.mtxtIDColet = new MetroFramework.Controls.MetroTextBox();
            this.mlblIDColet = new MetroFramework.Controls.MetroLabel();
            this.mtCautaDupaIDColet = new MetroFramework.Controls.MetroTile();
            this.mtCautaDupaDescriereColet = new MetroFramework.Controls.MetroTile();
            this.mlblEroareIDColet = new MetroFramework.Controls.MetroLabel();
            this.mlblEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mtxtDescriere
            // 
            this.mtxtDescriere.Location = new System.Drawing.Point(104, 127);
            this.mtxtDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDescriere.Name = "mtxtDescriere";
            this.mtxtDescriere.Size = new System.Drawing.Size(147, 20);
            this.mtxtDescriere.TabIndex = 14;
            // 
            // mlblDescriere
            // 
            this.mlblDescriere.AutoSize = true;
            this.mlblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDescriere.Location = new System.Drawing.Point(31, 128);
            this.mlblDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDescriere.Name = "mlblDescriere";
            this.mlblDescriere.Size = new System.Drawing.Size(69, 19);
            this.mlblDescriere.TabIndex = 13;
            this.mlblDescriere.Text = "Descriere ";
            // 
            // mtxtIDColet
            // 
            this.mtxtIDColet.Location = new System.Drawing.Point(104, 74);
            this.mtxtIDColet.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtIDColet.Name = "mtxtIDColet";
            this.mtxtIDColet.Size = new System.Drawing.Size(147, 20);
            this.mtxtIDColet.TabIndex = 12;
            // 
            // mlblIDColet
            // 
            this.mlblIDColet.AutoSize = true;
            this.mlblIDColet.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblIDColet.Location = new System.Drawing.Point(31, 75);
            this.mlblIDColet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblIDColet.Name = "mlblIDColet";
            this.mlblIDColet.Size = new System.Drawing.Size(59, 19);
            this.mlblIDColet.TabIndex = 11;
            this.mlblIDColet.Text = "ID Colet";
            // 
            // mtCautaDupaIDColet
            // 
            this.mtCautaDupaIDColet.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautaDupaIDColet.CustomBackground = true;
            this.mtCautaDupaIDColet.Location = new System.Drawing.Point(282, 74);
            this.mtCautaDupaIDColet.Name = "mtCautaDupaIDColet";
            this.mtCautaDupaIDColet.Size = new System.Drawing.Size(100, 19);
            this.mtCautaDupaIDColet.TabIndex = 16;
            this.mtCautaDupaIDColet.Text = "Cauta ";
            this.mtCautaDupaIDColet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautaDupaIDColet.Click += new System.EventHandler(this.mtCautaDupaIDColet_Click);
            // 
            // mtCautaDupaDescriereColet
            // 
            this.mtCautaDupaDescriereColet.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautaDupaDescriereColet.CustomBackground = true;
            this.mtCautaDupaDescriereColet.Location = new System.Drawing.Point(282, 128);
            this.mtCautaDupaDescriereColet.Name = "mtCautaDupaDescriereColet";
            this.mtCautaDupaDescriereColet.Size = new System.Drawing.Size(100, 20);
            this.mtCautaDupaDescriereColet.TabIndex = 17;
            this.mtCautaDupaDescriereColet.Text = "Cauta ";
            this.mtCautaDupaDescriereColet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautaDupaDescriereColet.Click += new System.EventHandler(this.mtCautaDupaDescriereColet_Click);
            // 
            // mlblEroareIDColet
            // 
            this.mlblEroareIDColet.AutoSize = true;
            this.mlblEroareIDColet.CustomForeColor = true;
            this.mlblEroareIDColet.ForeColor = System.Drawing.Color.Red;
            this.mlblEroareIDColet.Location = new System.Drawing.Point(104, 96);
            this.mlblEroareIDColet.Name = "mlblEroareIDColet";
            this.mlblEroareIDColet.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareIDColet.TabIndex = 18;
            // 
            // mlblEroareDescriere
            // 
            this.mlblEroareDescriere.AutoSize = true;
            this.mlblEroareDescriere.CustomForeColor = true;
            this.mlblEroareDescriere.ForeColor = System.Drawing.Color.Red;
            this.mlblEroareDescriere.Location = new System.Drawing.Point(104, 149);
            this.mlblEroareDescriere.Name = "mlblEroareDescriere";
            this.mlblEroareDescriere.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDescriere.TabIndex = 19;
            // 
            // FormCautareColet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mlblEroareDescriere);
            this.Controls.Add(this.mlblEroareIDColet);
            this.Controls.Add(this.mtCautaDupaDescriereColet);
            this.Controls.Add(this.mtCautaDupaIDColet);
            this.Controls.Add(this.mtxtDescriere);
            this.Controls.Add(this.mlblDescriere);
            this.Controls.Add(this.mtxtIDColet);
            this.Controls.Add(this.mlblIDColet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCautareColet";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Cautare colet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtDescriere;
        private MetroFramework.Controls.MetroLabel mlblDescriere;
        private MetroFramework.Controls.MetroTextBox mtxtIDColet;
        private MetroFramework.Controls.MetroLabel mlblIDColet;
        private MetroFramework.Controls.MetroTile mtCautaDupaIDColet;
        private MetroFramework.Controls.MetroTile mtCautaDupaDescriereColet;
        private MetroFramework.Controls.MetroLabel mlblEroareIDColet;
        private MetroFramework.Controls.MetroLabel mlblEroareDescriere;
    }
}