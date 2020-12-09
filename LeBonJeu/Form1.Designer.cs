namespace LeBonJeu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FigurinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LB_PHOTOS = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.RB_TOSTRING = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Genres = new System.Windows.Forms.ComboBox();
            this.LB_Jeux = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_Jeu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Jeu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerToolStripMenuItem,
            this.visualiserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.FigurinesToolStripMenuItem,
            this.modifierToolStripMenuItem});
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.gérerToolStripMenuItem.Text = "Gérer";
            this.gérerToolStripMenuItem.Click += new System.EventHandler(this.gérerToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // mangasToolStripMenuItem
            // 
            this.FigurinesToolStripMenuItem.Name = "mangasToolStripMenuItem";
            this.FigurinesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.FigurinesToolStripMenuItem.Text = "Mangas";
            this.FigurinesToolStripMenuItem.Click += new System.EventHandler(this.FigurinesToolStripMenuItem_Click);
            // 
            // visualiserToolStripMenuItem
            // 
            this.visualiserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuxToolStripMenuItem});
            this.visualiserToolStripMenuItem.Name = "visualiserToolStripMenuItem";
            this.visualiserToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.visualiserToolStripMenuItem.Text = "Visualiser";
            // 
            // jeuxToolStripMenuItem
            // 
            this.jeuxToolStripMenuItem.Name = "jeuxToolStripMenuItem";
            this.jeuxToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.jeuxToolStripMenuItem.Text = "Jeux";
            this.jeuxToolStripMenuItem.Click += new System.EventHandler(this.JeuxToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LB_PHOTOS);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1482, 825);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // LB_PHOTOS
            // 
            this.LB_PHOTOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_PHOTOS.FormattingEnabled = true;
            this.LB_PHOTOS.ItemHeight = 16;
            this.LB_PHOTOS.Location = new System.Drawing.Point(0, 0);
            this.LB_PHOTOS.Margin = new System.Windows.Forms.Padding(4);
            this.LB_PHOTOS.MaximumSize = new System.Drawing.Size(238, 1920);
            this.LB_PHOTOS.Name = "LB_PHOTOS";
            this.LB_PHOTOS.Size = new System.Drawing.Size(238, 825);
            this.LB_PHOTOS.TabIndex = 0;
            this.LB_PHOTOS.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LB_PHOTOS_DrawItem);
            this.LB_PHOTOS.SelectedIndexChanged += new System.EventHandler(this.LB_PHOTOS_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RB_TOSTRING);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1239, 825);
            this.splitContainer2.SplitterDistance = 508;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // RB_TOSTRING
            // 
            this.RB_TOSTRING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RB_TOSTRING.Location = new System.Drawing.Point(0, 0);
            this.RB_TOSTRING.Margin = new System.Windows.Forms.Padding(4);
            this.RB_TOSTRING.Name = "RB_TOSTRING";
            this.RB_TOSTRING.ReadOnly = true;
            this.RB_TOSTRING.Size = new System.Drawing.Size(508, 825);
            this.RB_TOSTRING.TabIndex = 0;
            this.RB_TOSTRING.Text = "";
            this.RB_TOSTRING.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 726F));
            this.tableLayoutPanel1.Controls.Add(this.CB_Genres, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LB_Jeux, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.PB_Jeu, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.98887F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.81581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.19533F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 825);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CB_Genres
            // 
            this.CB_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Genres.FormattingEnabled = true;
            this.CB_Genres.Location = new System.Drawing.Point(4, 91);
            this.CB_Genres.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Genres.Name = "CB_Genres";
            this.CB_Genres.Size = new System.Drawing.Size(718, 24);
            this.CB_Genres.TabIndex = 3;
            this.CB_Genres.SelectedIndexChanged += new System.EventHandler(this.CB_Genres_SelectedIndexChanged);
            // 
            // LB_Jeux
            // 
            this.LB_Jeux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Jeux.FormattingEnabled = true;
            this.LB_Jeux.ItemHeight = 16;
            this.LB_Jeux.Location = new System.Drawing.Point(4, 164);
            this.LB_Jeux.Margin = new System.Windows.Forms.Padding(4);
            this.LB_Jeux.Name = "LB_Jeux";
            this.LB_Jeux.Size = new System.Drawing.Size(718, 159);
            this.LB_Jeux.TabIndex = 4;
            this.LB_Jeux.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(718, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tous les jeux";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(4, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(718, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jeux retro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(718, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sélectionner un genre !";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // PB_Jeu
            // 
            this.PB_Jeu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Jeu.Location = new System.Drawing.Point(4, 331);
            this.PB_Jeu.Margin = new System.Windows.Forms.Padding(4);
            this.PB_Jeu.Name = "PB_Jeu";
            this.PB_Jeu.Size = new System.Drawing.Size(718, 488);
            this.PB_Jeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Jeu.TabIndex = 5;
            this.PB_Jeu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.PB_Jeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jeuxToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox RB_TOSTRING;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CB_Genres;
        private System.Windows.Forms.ListBox LB_Jeux;
        private System.Windows.Forms.PictureBox PB_Jeu;
        private System.Windows.Forms.ListBox LB_PHOTOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem FigurinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
    }
}

