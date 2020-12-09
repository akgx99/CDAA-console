
namespace LeBonJeu
{
    partial class Form2
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
            this.LB_Photos = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RB_ToString = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Genres = new System.Windows.Forms.ComboBox();
            this.LB_Figurines = new System.Windows.Forms.ListBox();
            this.PB_Figurine = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FigurinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Figurine)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LB_Photos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(600, 342);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // LB_Photos
            // 
            this.LB_Photos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Photos.FormattingEnabled = true;
            this.LB_Photos.Location = new System.Drawing.Point(0, 0);
            this.LB_Photos.Margin = new System.Windows.Forms.Padding(2);
            this.LB_Photos.Name = "LB_Photos";
            this.LB_Photos.Size = new System.Drawing.Size(164, 342);
            this.LB_Photos.TabIndex = 0;
            this.LB_Photos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LB_Photos_DrawItem);
            this.LB_Photos.SelectedIndexChanged += new System.EventHandler(this.LB_Photos_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RB_ToString);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(433, 342);
            this.splitContainer2.SplitterDistance = 204;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // RB_ToString
            // 
            this.RB_ToString.BackColor = System.Drawing.SystemColors.Menu;
            this.RB_ToString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_ToString.Location = new System.Drawing.Point(0, 0);
            this.RB_ToString.Margin = new System.Windows.Forms.Padding(2);
            this.RB_ToString.Name = "RB_ToString";
            this.RB_ToString.Size = new System.Drawing.Size(204, 342);
            this.RB_ToString.TabIndex = 0;
            this.RB_ToString.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CB_Genres, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_Figurines, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PB_Figurine, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51948F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.48052F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Séléctionnez une marque";
            // 
            // CB_Genres
            // 
            this.CB_Genres.AccessibleName = "CB_Genres";
            this.CB_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Genres.FormattingEnabled = true;
            this.CB_Genres.Location = new System.Drawing.Point(2, 40);
            this.CB_Genres.Margin = new System.Windows.Forms.Padding(2);
            this.CB_Genres.Name = "CB_Genres";
            this.CB_Genres.Size = new System.Drawing.Size(222, 21);
            this.CB_Genres.TabIndex = 3;
            // 
            // LB_Figurines
            // 
            this.LB_Figurines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Figurines.FormattingEnabled = true;
            this.LB_Figurines.Location = new System.Drawing.Point(2, 126);
            this.LB_Figurines.Margin = new System.Windows.Forms.Padding(2);
            this.LB_Figurines.Name = "LB_Figurines";
            this.LB_Figurines.Size = new System.Drawing.Size(222, 82);
            this.LB_Figurines.TabIndex = 4;
            // 
            // PB_Figurine
            // 
            this.PB_Figurine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Figurine.Location = new System.Drawing.Point(2, 212);
            this.PB_Figurine.Margin = new System.Windows.Forms.Padding(2);
            this.PB_Figurine.Name = "PB_Figurine";
            this.PB_Figurine.Size = new System.Drawing.Size(222, 128);
            this.PB_Figurine.TabIndex = 5;
            this.PB_Figurine.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FigurinesToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // FigurinesToolStripMenuItem
            // 
            this.FigurinesToolStripMenuItem.Name = "FigurinesToolStripMenuItem";
            this.FigurinesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FigurinesToolStripMenuItem.Text = "Figurines";
            this.FigurinesToolStripMenuItem.Click += new System.EventHandler(this.FigurinesToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Figurine)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ListBox LB_Photos;
        private System.Windows.Forms.RichTextBox RB_ToString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Genres;
        private System.Windows.Forms.ListBox LB_Figurines;
        private System.Windows.Forms.PictureBox PB_Figurine;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FigurinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
    }
}