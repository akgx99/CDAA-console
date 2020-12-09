using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    public class LesFigurines
    {
        private List<Figurine> listeFigurines;

        public LesFigurines()
        {
            this.listeFigurines = new List<Figurine>();
        }

        public void Init()
        {

            Figurine fig1 = new Figurine("SonGoku [dragon ball Z]", "une belle figurine très belle", MarqueFigurine.MonDieuDesFigurines, 120, DateTime.Today);
            Figurine fig2 = new Figurine("Koseï [your lie in april]", "Une figurine triste comme un confinement", MarqueFigurine.UltraFigurine, 60, DateTime.Today);

            fig1.Photo = Properties.Resources.Rayman;
            fig2.Photo = Properties.Resources.Pokemon;

            this.listeFigurines.Add(fig1);
            this.listeFigurines.Add(fig2);
        }

        public Figurine GetFigurineIndice(int indice)
        {
            return this.listeFigurines[indice];
        }

        public int CountFigurines()
        {
            return this.listeFigurines.Count;
        }

        public void Ajouter(Figurine fig)
        {
            this.listeFigurines.Add(fig);
        }

        public LesFigurines getFigurinesMarque(MarqueFigurine m)
        {
            LesFigurines lst = new LesFigurines();

            foreach(Figurine f in listeFigurines)
            {
                if(f.Marque == m)
                {
                    lst.Ajouter(f);
                }
            }

            return lst;
        }

        public void Supprimer(Figurine f)
        {
            this.listeFigurines.Remove(f);
        }

        public bool RechercherFigurine(Figurine f)
        {
            return this.listeFigurines.Contains(f);
        }

        public Figurine RechercherFigurineParNom(string s)
        {
            Figurine f = new Figurine();

            for (int i = 0; i < listeFigurines.Count; i++)
                if (this.listeFigurines[i].Nom.Equals(s))
                    f = this.listeFigurines[i];

            return f;
        }

        public void Saisie()
        {
            foreach(Figurine fig in listeFigurines)
            {
                fig.saisie();
            }
        }

        public void Affiche()
        {
            foreach(Figurine fig in listeFigurines)
            {
                fig.affiche();
            }
        }

        public override string ToString()
        {
            string s = "";

            foreach(Figurine fig in listeFigurines)
            {
                s += fig.ToString();
            }
            
            return s;
        }

        public void Tri()
        {
            int size = listeFigurines.Count;
            bool end = false;

            do
            {
                for(int i = size; i > 1; i--)
                    for(int j = 0; j < (i -1); j++)
                        if(listeFigurines[j].CompareTo(listeFigurines[j+1]) > 0)
                        {
                            Figurine temp = listeFigurines[j];
                            listeFigurines[j] = listeFigurines[j + 1];
                            listeFigurines[j + 1] = temp;
                        }
            } while(end);
        }

        public List<Figurine> ListeFigurines { get => listeFigurines; set => listeFigurines = value; }

    }
}
