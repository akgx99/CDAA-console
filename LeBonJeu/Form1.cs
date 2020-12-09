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
    public partial class Form1 : Form
    {
        private Catalogue leCat;
        private ImageList lph;
        private Image im;
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            leCat = new Catalogue();
            LesJeux lj = leCat.Lj;
            lj.Init();
            InitListeGenres();
            InitListeJeux();
            InitListeImage();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int a = this.LB_Jeux.SelectedIndex;
            Image img1 = this.lph.Images[a];
            PB_Jeu.Image = img1;*/

            try
            {
                Jeu jeuSelectionner = this.leCat.Lj.RechercheJeuParNom(this.LB_Jeux.SelectedItem.ToString());
                RB_TOSTRING.Text = jeuSelectionner.ToString();
                Image img1 = jeuSelectionner.Photo;
                PB_Jeu.Image = img1;
            }
            catch { };
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitListeGenres()
        {
            foreach (CategorieGenre g in Enum.GetValues(typeof(CategorieGenre)))
            {
                this.CB_Genres.Items.Add(g);
            }
        }

        private void InitListeJeux()
        {

            this.LB_Jeux.Items.Clear();
            foreach (Jeu j in this.leCat.Lj.ListeJeux)
            {
                this.LB_Jeux.Items.Add(j.Nom);
            }
           this.RB_TOSTRING.Text = this.leCat.Lj.ToString();
        }
            
            

        /// <summary>
        /// Initialise la liste d'image LB_PHOTOS
        /// </summary>
        private void InitListeImage()
        {
            this.lph = new ImageList();
            //lph.Images.Clear();
            this.LB_PHOTOS.Items.Clear();
            lph.ImageSize = new Size(168, 168);
            //this.lph.Images.Add(Properties.Resources.Pokemon);
            //this.lph.Images.Add(Properties.Resources.Rayman);
            this.LB_PHOTOS.DrawMode = DrawMode.OwnerDrawVariable;
            this.LB_PHOTOS.ItemHeight = 168;

            foreach(Jeu j in this.leCat.Lj.ListeJeux)
            {
                //lph.Images.Clear();
                //this.LB_PHOTOS.Items.Clear();
                lph.Images.Add(j.Photo);
                this.LB_PHOTOS.Items.Add(j.Nom);
            }
        }

            
        
        /// <summary>
        /// Evenement qui se déclenche lors de la sélection d'un objet dans un ComboBox
        /// Permet d'afficher les photos des jeux qui correspondent à un genre spécifique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CB_Genres_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.lph.Images.Clear();
                this.LB_PHOTOS.Items.Clear();
                this.LB_Jeux.Items.Clear();
                foreach (Jeu j in this.leCat.Lj.ListeJeux)
                {
                    if (j.GenreS.Equals(this.CB_Genres.SelectedItem.ToString()))
                    {
                        this.LB_Jeux.Items.Add(j.Nom);
                        this.lph.Images.Add(j.Photo);
                        this.LB_PHOTOS.Items.Add(j.Nom);
                    }
                }
            }
            catch { }
        }





        private void LV_PHOTOS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LB_PHOTOS_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Point p = e.Bounds.Location;
                this.lph.Draw(e.Graphics, p, e.Index);
            }
            //Point p = e.Bounds.Location;
            //this.lph.Draw(e.Graphics, p, e.Index);
            catch
            {


            }
        }
            

        private void LB_PHOTOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int a = this.LB_PHOTOS.SelectedIndex;
            Image img1 = this.lph.Images[a];
            PB_Jeu.Image = img1;*/

            Jeu jeuSelectionner = this.leCat.Lj.RechercheJeuParNom(this.LB_PHOTOS.SelectedItem.ToString());

            this.RB_TOSTRING.Text = jeuSelectionner.ToString();
            Image img1 = jeuSelectionner.Photo;
            PB_Jeu.Image = img1;

        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaisieJeuDlg diag = new SaisieJeuDlg();
            DialogResult res = diag.ShowDialog();
            if (res == DialogResult.OK)
            {
                leCat.AjouterJeu(diag.LeJeu);
                this.lph.Images.Add(diag.LeJeu.Photo);
                //this.lph.Images.Add(diag.LeJeuRetro.Photo);
                this.LB_PHOTOS.Items.Add(diag.LeJeu.Nom);
                InitListeJeux();
                InitListeImage();
            }
        }


        private void JeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualJeuDlg diag = new VisualJeuDlg(leCat.Lj);
            diag.ShowDialog();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ouvre la fenetre Form 2 lorsqu'on clique sur Mangas dans le toolStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FigurinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FigForm = new Form2();
            FigForm.ShowDialog();
        }

        /// <summary>
        /// Evenement qui se déclenche lorsqu'on clique sur le bouton "modifier" dans "Gérer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajJeuDlg majJeuForm = new MajJeuDlg(leCat.Lj);
            majJeuForm.ShowDialog();
            //leCat.Lj = majJeuForm.Lj;
            InitListeJeux();
        }
    }
}
