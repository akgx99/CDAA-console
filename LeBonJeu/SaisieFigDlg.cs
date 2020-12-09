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
    public partial class SaisieFigDlg : Form
    {
        private Figurine figurine;
        private Image ph;


        public SaisieFigDlg()
        {
            InitializeComponent();
            InitListeMarque();
        }

        public void InitListeMarque()
        {
            foreach (MarqueFigurine f in Enum.GetValues(typeof(MarqueFigurine)))
            {
                this.CB_Genres.Items.Add(f);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult res = dlg.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fichier = dlg.FileName;
                PB_Photo.Text = fichier;
                ph = Image.FromFile(fichier);
                this.NomFich.Text = fichier;
                PB_Photo.Image = ph.GetThumbnailImage(PB_Photo.Width, PB_Photo.Height, null, IntPtr.Zero);
            }
        }

        private void BValiderJeu_Click(object sender, EventArgs e)
        {

          
            MarqueFigurine marque = (MarqueFigurine)CB_Genres.SelectedItem;
            float prix;
            DateTime DateS = dateTimePicker1.Value;

            if (Prix.Text != "")
                prix = Single.Parse(Prix.Text);
            else prix = 0;

            this.figurine = new Figurine(Nom.Text, Description.Text, marque, prix, DateS);
            this.figurine.Photo = this.ph;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Figurine Figurine { get => figurine; set => figurine = value; }

    }
}
