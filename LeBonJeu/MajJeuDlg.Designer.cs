
namespace LeBonJeu
{
    partial class MajJeuDlg
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
            this.Grille = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).BeginInit();
            this.SuspendLayout();
            // 
            // Grille
            // 
            this.Grille.AllowUserToAddRows = false;
            this.Grille.AllowUserToDeleteRows = false;
            this.Grille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grille.Location = new System.Drawing.Point(0, 0);
            this.Grille.Name = "Grille";
            this.Grille.RowHeadersWidth = 51;
            this.Grille.RowTemplate.Height = 24;
            this.Grille.Size = new System.Drawing.Size(800, 450);
            this.Grille.TabIndex = 0;
            this.Grille.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grille_CellValueChanged);
            // 
            // MajJeuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Grille);
            this.Name = "MajJeuDlg";
            this.Text = "MajJeuDlg";
            ((System.ComponentModel.ISupportInitialize)(this.Grille)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grille;
    }
}