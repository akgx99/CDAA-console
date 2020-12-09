
namespace LeBonJeu
{
    partial class VisualFigDlg
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
            this.Edition = new System.Windows.Forms.RichTextBox();
            this.PB_Photo = new System.Windows.Forms.PictureBox();
            this.Arbre = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Arbre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 367;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Edition, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PB_Photo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Edition
            // 
            this.Edition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Edition.Location = new System.Drawing.Point(3, 3);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(423, 219);
            this.Edition.TabIndex = 0;
            this.Edition.Text = "";
            // 
            // PB_Photo
            // 
            this.PB_Photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Photo.Location = new System.Drawing.Point(3, 228);
            this.PB_Photo.Name = "PB_Photo";
            this.PB_Photo.Size = new System.Drawing.Size(423, 219);
            this.PB_Photo.TabIndex = 1;
            this.PB_Photo.TabStop = false;
            // 
            // Arbre
            // 
            this.Arbre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Arbre.Location = new System.Drawing.Point(0, 0);
            this.Arbre.Name = "Arbre";
            this.Arbre.Size = new System.Drawing.Size(367, 450);
            this.Arbre.TabIndex = 0;
            this.Arbre.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Arbre_AfterSelect);
            // 
            // VisualMangaDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VisualMangaDlg";
            this.Text = "VisualMangaDlg";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox Edition;
        private System.Windows.Forms.PictureBox PB_Photo;
        private System.Windows.Forms.TreeView Arbre;
    }
}