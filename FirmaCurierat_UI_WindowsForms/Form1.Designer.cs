using MetroFramework.Controls;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mTileAdauga = new MetroFramework.Controls.MetroTile();
            this.mTileActualizeazaLista = new MetroFramework.Controls.MetroTile();
            this.mTileCautare = new MetroFramework.Controls.MetroTile();
            this.dataGridComenziSiColete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenziSiColete)).BeginInit();
            this.SuspendLayout();
            // 
            // mTileAdauga
            // 
            this.mTileAdauga.BackColor = System.Drawing.Color.SlateGray;
            this.mTileAdauga.CustomBackground = true;
            this.mTileAdauga.ForeColor = System.Drawing.SystemColors.Info;
            this.mTileAdauga.Location = new System.Drawing.Point(36, 136);
            this.mTileAdauga.Name = "mTileAdauga";
            this.mTileAdauga.Size = new System.Drawing.Size(362, 99);
            this.mTileAdauga.Style = MetroFramework.MetroColorStyle.Silver;
            this.mTileAdauga.TabIndex = 13;
            this.mTileAdauga.Text = "Adauga Comanda";
            this.mTileAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAdauga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAdauga.Click += new System.EventHandler(this.mTileAdauga_Click);
            // 
            // mTileActualizeazaLista
            // 
            this.mTileActualizeazaLista.BackColor = System.Drawing.Color.SlateGray;
            this.mTileActualizeazaLista.CustomBackground = true;
            this.mTileActualizeazaLista.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mTileActualizeazaLista.Location = new System.Drawing.Point(36, 279);
            this.mTileActualizeazaLista.Name = "mTileActualizeazaLista";
            this.mTileActualizeazaLista.Size = new System.Drawing.Size(362, 111);
            this.mTileActualizeazaLista.TabIndex = 14;
            this.mTileActualizeazaLista.Text = "Actualizeaza Lista";
            this.mTileActualizeazaLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileActualizeazaLista.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileActualizeazaLista.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileActualizeazaLista.Click += new System.EventHandler(this.mTileActualizeazaLista_Click);
            // 
            // mTileCautare
            // 
            this.mTileCautare.BackColor = System.Drawing.Color.SlateGray;
            this.mTileCautare.CustomBackground = true;
            this.mTileCautare.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mTileCautare.Location = new System.Drawing.Point(36, 421);
            this.mTileCautare.Name = "mTileCautare";
            this.mTileCautare.Size = new System.Drawing.Size(362, 111);
            this.mTileCautare.TabIndex = 15;
            this.mTileCautare.Text = "Cauta comanda";
            this.mTileCautare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileCautare.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTileCautare.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileCautare.Click += new System.EventHandler(this.mTileCautare_Click);
            // 
            // dataGridComenziSiColete
            // 
            this.dataGridComenziSiColete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridComenziSiColete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridComenziSiColete.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridComenziSiColete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComenziSiColete.Location = new System.Drawing.Point(484, 136);
            this.dataGridComenziSiColete.Name = "dataGridComenziSiColete";
            this.dataGridComenziSiColete.RowHeadersWidth = 82;
            this.dataGridComenziSiColete.RowTemplate.Height = 33;
            this.dataGridComenziSiColete.Size = new System.Drawing.Size(2827, 1090);
            this.dataGridComenziSiColete.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(3381, 1451);
            this.Controls.Add(this.dataGridComenziSiColete);
            this.Controls.Add(this.mTileCautare);
            this.Controls.Add(this.mTileActualizeazaLista);
            this.Controls.Add(this.mTileAdauga);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 115, 20, 19);
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Infromatii comenzi si colete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComenziSiColete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroTile mTileAdauga;
        private MetroTile mTileActualizeazaLista;
        private MetroTile mTileCautare;
        private System.Windows.Forms.DataGridView dataGridComenziSiColete;
    }
}

