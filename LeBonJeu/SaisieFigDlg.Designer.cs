
namespace LeBonJeu
{
    partial class SaisieFigDlg
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Prix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CB_Genres = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.BValiderJeu = new System.Windows.Forms.Button();
            this.PB_Photo = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.NomFich = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(600, 366);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Description, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Prix, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CB_Genres, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.73529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.26471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 366);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AccessibleName = "Description";
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 205);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix";
            // 
            // Nom
            // 
            this.Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nom.Location = new System.Drawing.Point(145, 2);
            this.Nom.Margin = new System.Windows.Forms.Padding(2);
            this.Nom.Multiline = true;
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(139, 52);
            this.Nom.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.AccessibleName = "Description";
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(145, 58);
            this.Description.Margin = new System.Windows.Forms.Padding(2);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(139, 51);
            this.Description.TabIndex = 6;
            // 
            // Prix
            // 
            this.Prix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prix.Location = new System.Drawing.Point(145, 182);
            this.Prix.Margin = new System.Windows.Forms.Padding(2);
            this.Prix.Multiline = true;
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(139, 59);
            this.Prix.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Genre";
            // 
            // CB_Genres
            // 
            this.CB_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Genres.FormattingEnabled = true;
            this.CB_Genres.Location = new System.Drawing.Point(145, 113);
            this.CB_Genres.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Genres.Name = "CB_Genres";
            this.CB_Genres.Size = new System.Drawing.Size(139, 21);
            this.CB_Genres.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BValiderJeu, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.PB_Photo, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.NomFich, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95935F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.04065F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 366);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 193);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(2, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BValiderJeu
            // 
            this.BValiderJeu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BValiderJeu.Location = new System.Drawing.Point(157, 341);
            this.BValiderJeu.Margin = new System.Windows.Forms.Padding(2);
            this.BValiderJeu.Name = "BValiderJeu";
            this.BValiderJeu.Size = new System.Drawing.Size(152, 23);
            this.BValiderJeu.TabIndex = 13;
            this.BValiderJeu.Text = "Valider";
            this.BValiderJeu.UseVisualStyleBackColor = true;
            this.BValiderJeu.Click += new System.EventHandler(this.BValiderJeu_Click);
            // 
            // PB_Photo
            // 
            this.PB_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Photo.Location = new System.Drawing.Point(2, 252);
            this.PB_Photo.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Photo.Name = "PB_Photo";
            this.PB_Photo.Size = new System.Drawing.Size(151, 45);
            this.PB_Photo.TabIndex = 15;
            this.PB_Photo.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(157, 252);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 45);
            this.button3.TabIndex = 16;
            this.button3.Text = "Parcourir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NomFich
            // 
            this.NomFich.BackColor = System.Drawing.SystemColors.Menu;
            this.NomFich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NomFich.Location = new System.Drawing.Point(2, 301);
            this.NomFich.Margin = new System.Windows.Forms.Padding(2);
            this.NomFich.Multiline = true;
            this.NomFich.Name = "NomFich";
            this.NomFich.Size = new System.Drawing.Size(151, 36);
            this.NomFich.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date de sortie ?";
            // 
            // SaisieFigDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaisieFigDlg";
            this.Text = "SaisieFigDlg";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox Prix;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CB_Genres;
        private System.Windows.Forms.Button BValiderJeu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PB_Photo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NomFich;
    }
}