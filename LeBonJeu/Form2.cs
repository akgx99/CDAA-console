using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBonJeu
{
    public partial class Form2 : Form
    {
        private Catalogue cat;
        private ImageList lph;

        public Form2()
        {
            InitializeComponent();

            cat = new Catalogue();

            LesFigurines listeFig = cat.Lf;
            listeFig.Init();

            InitListeFigurines();
            InitListeMarques();
            InitListeImage();

        }

        private void LB_Photos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int select = this.LB_Photos.SelectedIndex;
            Image img = this.lph.Images[select];
            PB_Figurine.Image= img;
        }

        private void InitListeFigurines()
        {

            this.LB_Figurines.Items.Clear();
            foreach (Figurine f in this.cat.Lf.ListeFigurines)
            {
                this.LB_Figurines.Items.Add(f.Nom);
            }
            this.RB_ToString.Text = this.cat.Lf.ToString();
        }

        private void InitListeMarques()
        {
            foreach (MarqueFigurine m in Enum.GetValues(typeof(MarqueFigurine)))
            {
                this.CB_Genres.Items.Add(m);
            }
        }

        private void InitListeImage()
        {
            this.lph = new ImageList();
            lph.ImageSize = new Size(168, 168);

            this.lph.Images.Add(Properties.Resources.Pokemon);
            this.cat.Lf.ListeFigurines[0].Photo = Properties.Resources.Pokemon;
            this.LB_Photos.Items.Add("Pokemon");

            this.LB_Photos.DrawMode = DrawMode.OwnerDrawVariable;
            this.LB_Photos.ItemHeight = 168;
        }

        private void LB_Photos_DrawItem(object sender, DrawItemEventArgs e)
        {
            Point p = e.Bounds.Location;
            this.lph.Draw(e.Graphics, p, e.Index);
        }

        private void FigurinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualFigDlg VisualFigDlg = new VisualFigDlg(cat.Lf);
            VisualFigDlg.ShowDialog();
        }


        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieFigDlg diag = new SaisieFigDlg();
            DialogResult res = diag.ShowDialog();
            if (res == DialogResult.OK)
            {
                cat.AjouterFigurine(diag.Figurine);
                this.lph.Images.Add(diag.Figurine.Photo);
                this.LB_Photos.Items.Add(diag.Figurine.Nom);
                InitListeFigurines();
            }
        }


        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajFigDlg majFigForm = new MajFigDlg(cat.Lf);
            majFigForm.ShowDialog();
            InitListeFigurines();
        }
    }
}
