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
    public partial class SaisieJeuDlg : Form
    {
        private Jeu leJeu; // jeu à saisir
        private Image ph; // photo du jeu

        public Jeu LeJeu { get => leJeu; set => leJeu = value; }
        public Image Ph { get => ph; set => ph = value; }

        public SaisieJeuDlg()
        {
            InitializeComponent();
            this.CenterToScreen();
            leJeu = new Jeu();
            ph = null;
            InitListeGenres();

        }
        private void InitListeGenres()
        {
            foreach (CategorieGenre g in Enum.GetValues(typeof(CategorieGenre)))
            {
                this.CB_GENRES.Items.Add(g);
            }
        }

        private void BParcourir_Click_Click(object sender, EventArgs e)
        {
                OpenFileDialog dlg = new OpenFileDialog();
                DialogResult res = dlg.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string fichier = dlg.FileName;
                    PBPhoto.Text = fichier;
                    ph = Image.FromFile(fichier);
                    this.NomFich.Text = fichier;
                    PBPhoto.Image = ph.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height, null, IntPtr.Zero);
                }
        }

       
        private void BValiderJeu_Click(object sender, EventArgs e)
        {
            float prix;
            bool recond = false;
            DateTime ds = dateTimePicker1.Value;
            CategorieGenre cat = (CategorieGenre)CB_GENRES.SelectedItem;
            if (Prix.Text != "")
                prix = Single.Parse(Prix.Text);
            else prix = 0;
            if (BRNRecond.Checked) recond = true;
            //this.leJeu = new Jeu(Nom.Text, Description.Text, Plateforme.Text, cat, Editeur.Text, prix, recond, ds);
            this.leJeu = new Jeu(Nom.Text, Description.Text, Editeur.Text, Plateforme.Text, cat, prix, ds, recond);
            leJeu.Photo = this.ph;
        
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        //JeuRetro
        private void BValiderJeuRetro_Click(object sender, EventArgs e)
        {
            float prix;
            bool recond = false;
            string etat;
            bool notice = false;
            DateTime ds = dateTimePicker1.Value;
            CategorieGenre cat = (CategorieGenre)CB_GENRES.SelectedItem;
            if (Prix.Text != "")
                prix = Single.Parse(Prix.Text);
            else prix = 0;
            if (BRNRecond.Checked) recond = true;
            if (radioButton1.Checked) notice = true;
            //this.leJeu = new Jeu(Nom.Text, Description.Text, Editeur.Text, Plateforme.Text, cat, prix, ds, recond);
            /*this.LeJeuRetro = new JeuRetro(Etat.Text, notice, Nom.Text, Description.Text,
                Editeur.Text, Plateforme.Text, cat, prix, ds, recond);*/
            this.leJeu = new JeuRetro(Etat.Text, notice, Nom.Text, Description.Text,
                Editeur.Text, Plateforme.Text, cat, prix, ds, recond);
            leJeu.Photo = this.ph;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        
    }
}
