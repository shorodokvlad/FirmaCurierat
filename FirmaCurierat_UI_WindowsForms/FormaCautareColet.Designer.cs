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
            this.mlblEroareDescriere = new MetroFramework.Controls.MetroLabel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbCautareColet = new System.Windows.Forms.PictureBox();
            this.pnlCauta = new System.Windows.Forms.Panel();
            this.btnCauta = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCautareColet)).BeginInit();
            this.pnlCauta.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtDescriere
            // 
            this.mtxtDescriere.Location = new System.Drawing.Point(74, 71);
            this.mtxtDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDescriere.Name = "mtxtDescriere";
            this.mtxtDescriere.Size = new System.Drawing.Size(199, 20);
            this.mtxtDescriere.TabIndex = 14;
            // 
            // mlblDescriere
            // 
            this.mlblDescriere.AutoSize = true;
            this.mlblDescriere.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlblDescriere.Location = new System.Drawing.Point(1, 72);
            this.mlblDescriere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblDescriere.Name = "mlblDescriere";
            this.mlblDescriere.Size = new System.Drawing.Size(65, 19);
            this.mlblDescriere.TabIndex = 13;
            this.mlblDescriere.Text = "Descriere";
            // 
            // mlblEroareDescriere
            // 
            this.mlblEroareDescriere.AutoSize = true;
            this.mlblEroareDescriere.CustomForeColor = true;
            this.mlblEroareDescriere.ForeColor = System.Drawing.Color.Red;
            this.mlblEroareDescriere.Location = new System.Drawing.Point(74, 97);
            this.mlblEroareDescriere.Name = "mlblEroareDescriere";
            this.mlblEroareDescriere.Size = new System.Drawing.Size(0, 0);
            this.mlblEroareDescriere.TabIndex = 19;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pbCautareColet);
            this.pnlHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.Location = new System.Drawing.Point(1, 6);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(272, 42);
            this.pnlHeader.TabIndex = 75;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHeader.Location = new System.Drawing.Point(49, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(106, 17);
            this.lblHeader.TabIndex = 21;
            this.lblHeader.Text = "CAUTARE COLET";
            // 
            // pbCautareColet
            // 
            this.pbCautareColet.Image = ((System.Drawing.Image)(resources.GetObject("pbCautareColet.Image")));
            this.pbCautareColet.Location = new System.Drawing.Point(3, 2);
            this.pbCautareColet.Name = "pbCautareColet";
            this.pbCautareColet.Size = new System.Drawing.Size(40, 37);
            this.pbCautareColet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCautareColet.TabIndex = 20;
            this.pbCautareColet.TabStop = false;
            // 
            // pnlCauta
            // 
            this.pnlCauta.Controls.Add(this.btnCauta);
            this.pnlCauta.Location = new System.Drawing.Point(305, 72);
            this.pnlCauta.Name = "pnlCauta";
            this.pnlCauta.Size = new System.Drawing.Size(123, 21);
            this.pnlCauta.TabIndex = 76;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.btnCauta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.ForeColor = System.Drawing.Color.White;
            this.btnCauta.Image = ((System.Drawing.Image)(resources.GetObject("btnCauta.Image")));
            this.btnCauta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauta.Location = new System.Drawing.Point(-20, -6);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Padding = new System.Windows.Forms.Padding(25, 0, 0, 13);
            this.btnCauta.Size = new System.Drawing.Size(151, 50);
            this.btnCauta.TabIndex = 21;
            this.btnCauta.Text = "             Cauta";
            this.btnCauta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            this.btnCauta.MouseEnter += new System.EventHandler(this.btnCauta_MouseEnter);
            this.btnCauta.MouseLeave += new System.EventHandler(this.btnCauta_MouseLeave);
            // 
            // FormCautareColet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCauta);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.mlblEroareDescriere);
            this.Controls.Add(this.mtxtDescriere);
            this.Controls.Add(this.mlblDescriere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCautareColet";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCautareColet)).EndInit();
            this.pnlCauta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxtDescriere;
        private MetroFramework.Controls.MetroLabel mlblDescriere;
        private MetroFramework.Controls.MetroLabel mlblEroareDescriere;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbCautareColet;
        private System.Windows.Forms.Panel pnlCauta;
        private System.Windows.Forms.Button btnCauta;
    }
}