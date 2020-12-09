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
    public partial class VisualFigDlg : Form
    {
        private LesFigurines lf;
        public VisualFigDlg(LesFigurines lf)
        {
            InitializeComponent();
            this.lf = lf;
            InitArbre();
        }

        private void InitArbre()
        {
            foreach (MarqueFigurine m in Enum.GetValues(typeof(MarqueFigurine)))
            {
                TreeNode node = new TreeNode(m.ToString());
                LesFigurines figurines = this.lf.getFigurinesMarque(m);
                foreach (Figurine f in figurines.ListeFigurines)
                {
                    TreeNode nodeIndex = new TreeNode(f.Nom);
                    node.Nodes.Add(nodeIndex);
                }
                Arbre.Nodes.Add(node);
            }
        }

        private void Arbre_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nd = e.Node;
            if (nd.Level > 0)
            {
                Figurine f = this.lf.RechercherFigurineParNom(nd.Text);
                if (f != null)
                {
                    Edition.Text = f.ToString();
                    PB_Photo.Image = f.Photo.GetThumbnailImage(PB_Photo.Width, PB_Photo.Height,
                    null, IntPtr.Zero);
                }
            }
        }
    }
}
