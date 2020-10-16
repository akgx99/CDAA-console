using System;
using System.Collections.Generic;
using System.Text;

namespace TPCDAA
{

    //TODO
    //methode init() avec des jeux

    /// <summary>
    /// Classe représentant un ensemble de Jeux
    /// </summary>
    public class LesJeux
    {
        private List<Jeu> listeJeux;

        /// <summary>
        /// Constructeur LesJeux
        /// </summary>
        public LesJeux()
        {
            this.listeJeux = new List<Jeu>();
        }

        /// <summary>
        /// Permet de récupérer un jeu en fonction de son indice dans liste
        /// </summary>
        /// <param name="indice">L'indice du jeu à récupérer</param>
        /// <returns></returns>
        public Jeu GetJeuIndice(int indice)
        {
            return this.listeJeux[indice];
        }

        /// <summary>
        /// Permet de connaître la Taille de la liste
        /// </summary>
        /// <returns>Le nombre de jeu dans la liste</returns>
        public int NbJeux()
        {
            return this.listeJeux.Count;
        }

        /// <summary>
        /// Permet d'ajouter un jeu
        /// </summary>
        /// <param name="jeu">Le jeu à ajouter</param>
        public void AjouterJeu(Jeu jeu)
        {
            this.listeJeux.Add(jeu);
        }

        /// <summary>
        /// Permet d'avoir une liste de tous les jeux d'un même genre
        /// </summary>
        /// <param name="g">Le genre à chercher</param>
        /// <returns>Une liste des jeux du genre spécifié</returns>
        public LesJeux GetJeuxGenre(CategorieGenre g)
        {
            LesJeux lst = new LesJeux();

            foreach (Jeu jeu in listeJeux)
            {
                if (jeu.Genre == g)
                {
                    lst.AjouterJeu(jeu);
                }
            }

            return lst;
        }

        /// <summary>
        /// Permet de supprimer un Jeu
        /// </summary>
        /// <param name="jeu">Le Jeu à supprimer</param>
        public void supprimerJeu(Jeu jeu)
        {
            this.listeJeux.Remove(jeu);
        }

        /// <summary>
        /// Permet de rechercher un jeu dans la liste
        /// </summary>
        /// <param name="jeu">Le jeu à rechercher</param>
        /// <returns>True ou False</returns>
        public bool rechercheJeu(Jeu jeu)
        {
            return this.listeJeux.Contains(jeu);
        }


        /// <summary>
        /// Permet de rechercher les JeuRetro dans la liste
        /// </summary>
        /// <returns>La liste des JeuRetro</returns>
        public List<Jeu> RechercheJeuRetro()
        {
            List<Jeu> jeuRetroList = new List<Jeu>();

            foreach(Jeu j in this.listeJeux)
            {
                if(j.GetType() == typeof(JeuRetro))
                {
                    jeuRetroList.Add(j);
                }
            }

            return jeuRetroList;
        }

        /// <summary>
        /// Tostring de LesJeux
        /// </summary>
        /// <returns>L'ensemble des ToString de chaque Jeu</returns>
        public override string ToString()
        {
            string s = "";

            foreach (Jeu jeu in listeJeux)
            {
                s += jeu.ToString();
            }

            return s;
        }

        /// <summary>
        /// Permet d'initliaser un set de jeu
        /// </summary>
        public void init()
        {
            this.AjouterJeu(new Jeu("The Witcher III", "Jeu de l'année 2015...", "CD projeckt" ,"PS4/XBO/SWITCH/PC", CategorieGenre.ActionRPG, 40, new DateTime(2015, 05, 13), false));
            this.AjouterJeu(new Jeu("DOOM", "ça fait bim bam boom...", "Bethesda", "PS4/XBO/SWITCH/PC", CategorieGenre.Autre, 50, new DateTime(2018, 06, 23), false));
            this.AjouterJeu(new Jeu("Animal Crossing new horizons", "Sur une île désserte...", "Nintendo", "SWITCH", CategorieGenre.Autre, 40, new DateTime(2020, 05, 06), false));
            this.AjouterJeu(new JeuRetro("Bon état", true, "Pong", "Jeu emblématique...", "Atari", "Borne d'arcade", CategorieGenre.Arcade, 2, new DateTime(1972, 11, 29), true));
        }

        /// <summary>
        /// Permet de trier la liste par ordre alphabétique des noms des Jeux (tri à bulles)
        /// </summary>
        public void Tri()
        {
            int size = listeJeux.Count;
            bool trie = false;

            do
            {
                for (int i = size; i - 1 > 1; i--)
                {
                    trie = false;

                    for (int j = 0; j < i - 1; j++)
                    {
                        if (listeJeux[j + 1] < listeJeux[j])
                        {
                            Jeu temp = listeJeux[j];
                            listeJeux[j] = listeJeux[j + 1];
                            listeJeux[j + 1] = temp;
                            trie = true;
                        }
                    }
                }
            } while (trie);
        }

        public List<Jeu> ListeJeux { get => listeJeux; set => listeJeux = value; }

    }
}
