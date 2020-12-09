namespace LeBonJeu
{
    partial class SaisieJeuDlg
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
            this.TB_JeuxRetro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Plateforme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Editeur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BRNRecond = new System.Windows.Forms.RadioButton();
            this.BAnnuler = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_GENRES = new System.Windows.Forms.ComboBox();
            this.Prix = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BParcourir_Click = new System.Windows.Forms.Button();
            this.PBPhoto = new System.Windows.Forms.PictureBox();
            this.BValider = new System.Windows.Forms.Button();
            this.NomFich = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Etat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.TB_JeuxRetro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_JeuxRetro
            // 
            this.TB_JeuxRetro.Controls.Add(this.tabPage1);
            this.TB_JeuxRetro.Controls.Add(this.tabPage2);
            this.TB_JeuxRetro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_JeuxRetro.Location = new System.Drawing.Point(0, 0);
            this.TB_JeuxRetro.Margin = new System.Windows.Forms.Padding(4);
            this.TB_JeuxRetro.Name = "TB_JeuxRetro";
            this.TB_JeuxRetro.SelectedIndex = 0;
            this.TB_JeuxRetro.Size = new System.Drawing.Size(1332, 653);
            this.TB_JeuxRetro.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1324, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jeu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 550;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(1316, 616);
            this.splitContainer1.SplitterDistance = 578;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Plateforme, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Editeur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BAnnuler, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 616);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ?";
            // 
            // Nom
            // 
            this.Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nom.Location = new System.Drawing.Point(293, 4);
            this.Nom.Margin = new System.Windows.Forms.Padding(4);
            this.Nom.Multiline = true;
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(281, 94);
            this.Nom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description ?";
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(293, 106);
            this.Description.Margin = new System.Windows.Forms.Padding(4);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(281, 91);
            this.Description.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plateforme ?";
            // 
            // Plateforme
            // 
            this.Plateforme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plateforme.Location = new System.Drawing.Point(293, 205);
            this.Plateforme.Margin = new System.Windows.Forms.Padding(4);
            this.Plateforme.Multiline = true;
            this.Plateforme.Name = "Plateforme";
            this.Plateforme.Size = new System.Drawing.Size(281, 94);
            this.Plateforme.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editeur ?";
            // 
            // Editeur
            // 
            this.Editeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Editeur.Location = new System.Drawing.Point(293, 307);
            this.Editeur.Margin = new System.Windows.Forms.Padding(4);
            this.Editeur.Multiline = true;
            this.Editeur.Name = "Editeur";
            this.Editeur.Size = new System.Drawing.Size(281, 99);
            this.Editeur.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.BRNRecond);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(293, 414);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(281, 98);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 41);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non reconditionné ?";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // BRNRecond
            // 
            this.BRNRecond.AutoSize = true;
            this.BRNRecond.Checked = true;
            this.BRNRecond.Location = new System.Drawing.Point(9, 11);
            this.BRNRecond.Margin = new System.Windows.Forms.Padding(4);
            this.BRNRecond.Name = "BRNRecond";
            this.BRNRecond.Size = new System.Drawing.Size(132, 21);
            this.BRNRecond.TabIndex = 0;
            this.BRNRecond.TabStop = true;
            this.BRNRecond.Text = "Reconditionné ?";
            this.BRNRecond.UseVisualStyleBackColor = true;
            // 
            // BAnnuler
            // 
            this.BAnnuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BAnnuler.Location = new System.Drawing.Point(293, 520);
            this.BAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.BAnnuler.Name = "BAnnuler";
            this.BAnnuler.Size = new System.Drawing.Size(281, 92);
            this.BAnnuler.TabIndex = 12;
            this.BAnnuler.Text = "ANNULER";
            this.BAnnuler.UseVisualStyleBackColor = true;
            this.BAnnuler.Click += new System.EventHandler(this.BAnnuler_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CB_GENRES, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Prix, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BParcourir_Click, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.PBPhoto, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.BValider, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.NomFich, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 616);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Genre ?";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prix ?";
            // 
            // CB_GENRES
            // 
            this.CB_GENRES.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_GENRES.FormattingEnabled = true;
            this.CB_GENRES.Location = new System.Drawing.Point(369, 3);
            this.CB_GENRES.Name = "CB_GENRES";
            this.CB_GENRES.Size = new System.Drawing.Size(361, 24);
            this.CB_GENRES.TabIndex = 23;
            // 
            // Prix
            // 
            this.Prix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prix.Location = new System.Drawing.Point(370, 108);
            this.Prix.Margin = new System.Windows.Forms.Padding(4);
            this.Prix.Multiline = true;
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(359, 90);
            this.Prix.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(369, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date de parution ?";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Photo ?";
            // 
            // BParcourir_Click
            // 
            this.BParcourir_Click.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BParcourir_Click.Location = new System.Drawing.Point(370, 304);
            this.BParcourir_Click.Margin = new System.Windows.Forms.Padding(4);
            this.BParcourir_Click.Name = "BParcourir_Click";
            this.BParcourir_Click.Size = new System.Drawing.Size(359, 102);
            this.BParcourir_Click.TabIndex = 19;
            this.BParcourir_Click.Text = "Parcourir";
            this.BParcourir_Click.UseVisualStyleBackColor = true;
            this.BParcourir_Click.Click += new System.EventHandler(this.BParcourir_Click_Click);
            // 
            // PBPhoto
            // 
            this.PBPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBPhoto.Location = new System.Drawing.Point(370, 414);
            this.PBPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.PBPhoto.Name = "PBPhoto";
            this.PBPhoto.Size = new System.Drawing.Size(359, 129);
            this.PBPhoto.TabIndex = 20;
            this.PBPhoto.TabStop = false;
            // 
            // BValider
            // 
            this.BValider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BValider.Location = new System.Drawing.Point(4, 551);
            this.BValider.Margin = new System.Windows.Forms.Padding(4);
            this.BValider.Name = "BValider";
            this.BValider.Size = new System.Drawing.Size(358, 61);
            this.BValider.TabIndex = 22;
            this.BValider.Text = "Valider";
            this.BValider.UseVisualStyleBackColor = true;
            this.BValider.Click += new System.EventHandler(this.BValiderJeu_Click);
            // 
            // NomFich
            // 
            this.NomFich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NomFich.Location = new System.Drawing.Point(4, 414);
            this.NomFich.Margin = new System.Windows.Forms.Padding(4);
            this.NomFich.Multiline = true;
            this.NomFich.Name = "NomFich";
            this.NomFich.ReadOnly = true;
            this.NomFich.Size = new System.Drawing.Size(358, 129);
            this.NomFich.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1324, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jeu Retro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Etat, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1316, 616);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Etat ?";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Notice ?";
            // 
            // Etat
            // 
            this.Etat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Etat.Location = new System.Drawing.Point(661, 3);
            this.Etat.Multiline = true;
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(652, 141);
            this.Etat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(661, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(652, 129);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BValiderJeuRetro_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(652, 129);
            this.button2.TabIndex = 5;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(661, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(42, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Oui";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(42, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Non";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SaisieJeuDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.TB_JeuxRetro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaisieJeuDlg";
            this.Text = "SaisieJeuDlg";
            this.TB_JeuxRetro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TB_JeuxRetro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Editeur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Plateforme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton BRNRecond;
        private System.Windows.Forms.Button BAnnuler;
        private System.Windows.Forms.TextBox Prix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BValider;
        private System.Windows.Forms.TextBox NomFich;
        private System.Windows.Forms.PictureBox PBPhoto;
        private System.Windows.Forms.Button BParcourir_Click;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_GENRES;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Etat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}