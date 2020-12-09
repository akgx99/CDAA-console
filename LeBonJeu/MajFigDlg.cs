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
    public partial class MajFigDlg : Form
    {
        private LesFigurines lf;
        public MajFigDlg(LesFigurines lf)
        {
            
            InitializeComponent();
            this.lf = lf;
            InitGrille();
        }

        private void InitGrille()
        {
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Description";
            Description.Name = "Editeur";
            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            DataGridViewTextBoxColumn DateS = new DataGridViewTextBoxColumn();
            DateS.HeaderText = "DateS";
            DateS.Name = "DateS";
            DataGridViewImageColumn Image = new DataGridViewImageColumn();
            Image.HeaderText = "Image";
            Image.Name = "Image";
            DataGridViewComboBoxColumn Marque = new DataGridViewComboBoxColumn();
            Marque.HeaderText = "Marque";
            Marque.Name = "Marque";
            Marque.DataSource = Enum.GetNames(typeof(MarqueFigurine));
            

            Grille.Columns.AddRange(new DataGridViewColumn[]  { Nom, Description, Prix, DateS, Image, Marque});
            Grille.Rows.Add(this.lf.ListeFigurines.Count);

            int i = 0;
            foreach (Figurine f in this.lf.ListeFigurines)
            {
                Grille.Rows[i].Cells["Nom"].Value = f.Nom;
                Grille.Rows[i].Cells["Description"].Value = f.Description;
                Grille.Rows[i].Cells["Prix"].Value = f.Prix.ToString();
                Grille.Rows[i].Cells["DateS"].Value = f.DateS.ToString("dd/MM/yyyy");
                Grille.Rows[i].Cells["Image"].Value = f.Photo.GetThumbnailImage(40, 30, null, IntPtr.Zero);
                Grille.Rows[i].Cells["Marque"].Value = f.Marque.ToString();
                i++;
            }
        }
        private void Grille_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int ligne = e.RowIndex;
            int colonne = e.ColumnIndex;
            DataGridViewCell cell = Grille.Rows[ligne].Cells[colonne];
            Figurine m = this.lf.ListeFigurines[ligne];

            switch (colonne)
            {
                case 0:
                    m.Nom = cell.Value.ToString();
                    break;
                case 1:
                    m.Description = cell.Value.ToString();
                    break;
                case 2:
                    m.Prix = Single.Parse(cell.Value.ToString());
                    break;
                case 3:
                    m.MarqueS = cell.Value.ToString();
                    break;
            }
        }
        public LesFigurines Lm { get => lf; set => lf = value; }
    }
}
                
                
                

                
                


