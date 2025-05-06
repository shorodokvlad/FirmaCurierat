using MetroFramework.Controls;

namespace FirmaCurierat_UI_WindowsForms
{
    partial class FormaAfisare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaAfisare));
            this.mtAdauga = new MetroFramework.Controls.MetroTile();
            this.mtActualizeazaLista = new MetroFramework.Controls.MetroTile();
            this.mtCautare = new MetroFramework.Controls.MetroTile();
            this.dataGridComenziSiColete = new System.Windows.Forms.DataGridView();
            this.mtCautaColet = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenziSiColete)).BeginInit();
            this.SuspendLayout();
            // 
            // mtAdauga
            // 
            this.mtAdauga.BackColor = System.Drawing.Color.SlateGray;
            this.mtAdauga.CustomBackground = true;
            this.mtAdauga.ForeColor = System.Drawing.SystemColors.Info;
            this.mtAdauga.Location = new System.Drawing.Point(18, 71);
            this.mtAdauga.Margin = new System.Windows.Forms.Padding(2);
            this.mtAdauga.Name = "mtAdauga";
            this.mtAdauga.Size = new System.Drawing.Size(181, 51);
            this.mtAdauga.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtAdauga.TabIndex = 13;
            this.mtAdauga.Text = "Adauga comanda";
            this.mtAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAdauga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAdauga.Click += new System.EventHandler(this.mtAdauga_Click);
            // 
            // mtActualizeazaLista
            // 
            this.mtActualizeazaLista.BackColor = System.Drawing.Color.SlateGray;
            this.mtActualizeazaLista.CustomBackground = true;
            this.mtActualizeazaLista.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mtActualizeazaLista.Location = new System.Drawing.Point(18, 140);
            this.mtActualizeazaLista.Margin = new System.Windows.Forms.Padding(2);
            this.mtActualizeazaLista.Name = "mtActualizeazaLista";
            this.mtActualizeazaLista.Size = new System.Drawing.Size(181, 58);
            this.mtActualizeazaLista.TabIndex = 14;
            this.mtActualizeazaLista.Text = "Actualizeaza lista";
            this.mtActualizeazaLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtActualizeazaLista.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtActualizeazaLista.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtActualizeazaLista.Click += new System.EventHandler(this.mtActualizeazaLista_Click);
            // 
            // mtCautare
            // 
            this.mtCautare.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautare.CustomBackground = true;
            this.mtCautare.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mtCautare.Location = new System.Drawing.Point(18, 219);
            this.mtCautare.Margin = new System.Windows.Forms.Padding(2);
            this.mtCautare.Name = "mtCautare";
            this.mtCautare.Size = new System.Drawing.Size(181, 58);
            this.mtCautare.TabIndex = 15;
            this.mtCautare.Text = "Cauta comanda";
            this.mtCautare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautare.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCautare.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCautare.Click += new System.EventHandler(this.mtCautare_Click);
            // 
            // dataGridComenziSiColete
            // 
            this.dataGridComenziSiColete.AllowUserToResizeColumns = false;
            this.dataGridComenziSiColete.AllowUserToResizeRows = false;
            this.dataGridComenziSiColete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridComenziSiColete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridComenziSiColete.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridComenziSiColete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridComenziSiColete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComenziSiColete.Location = new System.Drawing.Point(242, 68);
            this.dataGridComenziSiColete.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridComenziSiColete.Name = "dataGridComenziSiColete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridComenziSiColete.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridComenziSiColete.RowHeadersVisible = false;
            this.dataGridComenziSiColete.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.dataGridComenziSiColete.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridComenziSiColete.RowTemplate.Height = 33;
            this.dataGridComenziSiColete.Size = new System.Drawing.Size(1407, 562);
            this.dataGridComenziSiColete.TabIndex = 16;
            // 
            // mtCautaColet
            // 
            this.mtCautaColet.BackColor = System.Drawing.Color.SlateGray;
            this.mtCautaColet.CustomBackground = true;
            this.mtCautaColet.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mtCautaColet.Location = new System.Drawing.Point(18, 297);
            this.mtCautaColet.Margin = new System.Windows.Forms.Padding(2);
            this.mtCautaColet.Name = "mtCautaColet";
            this.mtCautaColet.Size = new System.Drawing.Size(181, 58);
            this.mtCautaColet.TabIndex = 17;
            this.mtCautaColet.Text = "Cauta colet";
            this.mtCautaColet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCautaColet.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCautaColet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCautaColet.Click += new System.EventHandler(this.mtCautaColet_Click);
            // 
            // FormaAfisare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1680, 567);
            this.Controls.Add(this.mtCautaColet);
            this.Controls.Add(this.dataGridComenziSiColete);
            this.Controls.Add(this.mtCautare);
            this.Controls.Add(this.mtActualizeazaLista);
            this.Controls.Add(this.mtAdauga);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaAfisare";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Infromatii comenzi si colete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenziSiColete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroTile mtAdauga;
        private MetroTile mtActualizeazaLista;
        private MetroTile mtCautare;
        private System.Windows.Forms.DataGridView dataGridComenziSiColete;
        private MetroTile mtCautaColet;
    }
}

