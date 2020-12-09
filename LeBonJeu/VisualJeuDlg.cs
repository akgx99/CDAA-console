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
    public partial class VisualJeuDlg : Form
    {
        private LesJeux lj;
        public VisualJeuDlg(LesJeux lj)
        {
            InitializeComponent();
            this.lj = lj;
            InitArbre();
        }
        private void InitArbre()
        {
            foreach (CategorieGenre cr in Enum.GetValues(typeof(CategorieGenre)))
            {
                TreeNode nd = new TreeNode(cr.ToString());
                LesJeux l = this.lj.GetJeuxGenre(cr);
                foreach (Jeu j in l.ListeJeux)
                {
                    TreeNode na = new TreeNode(j.Nom);
                    nd.Nodes.Add(na);
                }
                Arbre.Nodes.Add(nd);
            }
        }

        private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nd = e.Node;
            if (nd.Level > 0)
            {
                //Jeu j = this.lj.rechercher(nd.Text);
                Jeu j = this.lj.RechercheJeuParNom(nd.Text);
                if (j != null)
                {
                    Edition.Text = j.ToString();
                    PBPhoto.Image = j.Photo.GetThumbnailImage(PBPhoto.Width, PBPhoto.Height,
                    null, IntPtr.Zero);
                }
            }

        }
    }
}
