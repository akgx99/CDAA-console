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
    public partial class MajJeuDlg : Form
    {
        private LesJeux lj;
        public MajJeuDlg(LesJeux lj)
        {
            InitializeComponent();
            this.lj = lj;
            InitGrille();
        }

        private void InitGrille()
        {
            DataGridViewTextBoxColumn Nom = new DataGridViewTextBoxColumn();// texte
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            DataGridViewTextBoxColumn Description = new DataGridViewTextBoxColumn();
            Description.HeaderText = "Description";
            Description.Name = "Description";
            DataGridViewTextBoxColumn Plateforme = new DataGridViewTextBoxColumn();
            Plateforme.HeaderText = "Plateforme";
            Plateforme.Name = "Plateforme";
            DataGridViewComboBoxColumn Genre = new DataGridViewComboBoxColumn();// liste déroulante
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.DataSource = Enum.GetNames(typeof(CategorieGenre));
            DataGridViewTextBoxColumn Editeur = new DataGridViewTextBoxColumn();
            Editeur.HeaderText = "Editeur";
            Editeur.Name = "Editeur";
            DataGridViewTextBoxColumn Prix = new DataGridViewTextBoxColumn();
            Prix.HeaderText = "Prix";
            Prix.Name = "Prix";
            DataGridViewTextBoxColumn DateS = new DataGridViewTextBoxColumn();
            DateS.HeaderText = "DateS";
            DateS.Name = "DateS";
            DataGridViewCheckBoxColumn Recond = new DataGridViewCheckBoxColumn();// case à cocher
            Recond.HeaderText = "Recond";
            Recond.Name = "Recond";
            DataGridViewImageColumn Image = new DataGridViewImageColumn();// image
            Image.HeaderText = "Image";
            Image.Name = "Image";
            DataGridViewCheckBoxColumn Retro = new DataGridViewCheckBoxColumn();
            Retro.HeaderText = "Retro";
            Retro.Name = "Retro";
            DataGridViewTextBoxColumn Etat = new DataGridViewTextBoxColumn();
            Etat.HeaderText = "Etat";
            Etat.Name = "Etat";
            DataGridViewCheckBoxColumn Notice = new DataGridViewCheckBoxColumn();
            Notice.HeaderText = "Notice";
            Notice.Name = "Notice";

            Grille.Columns.AddRange(new DataGridViewColumn[]  { Nom,  Description,  Plateforme,  Genre, Editeur,
                Prix, DateS, Recond, Image, Retro, Etat, Notice });
            Grille.Rows.Add(this.lj.ListeJeux.Count);

            int i = 0;
            foreach(Jeu j in this.lj.ListeJeux)
            {
                Grille.Rows[i].Cells["Nom"].Value = j.Nom;
                Grille.Rows[i].Cells["Description"].Value = j.Description;
                Grille.Rows[i].Cells["Plateforme"].Value = j.Plateforme;
                Grille.Rows[i].Cells["Genre"].Value = j.Genre.ToString();
                Grille.Rows[i].Cells["Editeur"].Value = j.Editeur;
                Grille.Rows[i].Cells["Prix"].Value = j.Prix.ToString();
                Grille.Rows[i].Cells["DateS"].Value = j.DateS.ToString("dd/MM/yyyy");
                Grille.Rows[i].Cells["Image"].Value = j.Photo.GetThumbnailImage(40, 30, null, IntPtr.Zero);

                if (j is JeuRetro)
                {
                    Grille.Rows[i].Cells["Retro"].Value = true;
                    Grille.Rows[i].Cells["Etat"].Value = ((JeuRetro)j).Etat;
                    Grille.Rows[i].Cells["Notice"].Value = ((JeuRetro)j).Notice;
                }

                else
                {
                    Grille.Rows[i].Cells["Retro"].Value = false;
                }
                i++;
            }
        }

        private void Grille_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int lig = e.RowIndex; 
            int col = e.ColumnIndex;
            DataGridViewCell cell = Grille.Rows[lig].Cells[col];
            Jeu j = this.lj.ListeJeux[lig];

            switch(col)
            {
                case 0 :
                    j.Nom = cell.Value.ToString();
                    break;
                case 1 :
                    j.Description = cell.Value.ToString();
                    break;
                case 2 :
                    j.Plateforme = cell.Value.ToString();
                    break;
                case 3 : 
                    j.GenreS = cell.Value.ToString();
                    break;
                case 4:
                    j.Editeur = cell.Value.ToString();
                    break;
                case 5 :
                    j.Prix = Single.Parse(cell.Value.ToString());
                    break;
                /*case 6:
                    j.DateS = cell.Value.ToString();
                    break;*/
                case 7:
                    j.Record = (bool)cell.Value;
                    break;
                case 9 :
                    if (j is JeuRetro)
                        ((JeuRetro)j).Notice = (bool)cell.Value;
                    else
                        cell.Value = false;
                    break;
            }
        }

        public LesJeux Lj { get => lj; set => lj = value; }
    }

                    
                   
}
