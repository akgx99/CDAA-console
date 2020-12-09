using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonJeu
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

        public void Init()
        {
            Jeu jeu1 = new Jeu("League Of Legends", "Jouez en équipe pour parvenir à la victoire", "Riot Games", "PC", CategorieGenre.Strategie, 0, DateTime.Today, false);
            jeu1.Photo = Properties.Resources.Pokemon;
            //this.listeJeux.Add(new Jeu("Animal crossing", "Le meilleur jeu de l'année 2020", "Nintendo", "Switch", CategorieGenre.Autre, 60, DateTime.Today, true));
            //this.listeJeux.Add(new Jeu("League of Legends", "Le pire jeu du monde", "Riot", "PC master race", CategorieGenre.Strategie, 1, DateTime.Today, true));
            Jeu jeu2 = new Jeu("Animal Crossing", "Construisez votre village", "Nintendo", "Nintendo Switch", CategorieGenre.Autre, 60, DateTime.Today, true);
            jeu2.Photo = Properties.Resources.Rayman;
            this.listeJeux.Add(jeu1);
            this.listeJeux.Add(jeu2);
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
        public void SupprimerJeu(Jeu jeu)
        {
            this.listeJeux.Remove(jeu);
        }

        /// <summary>
        /// Permet de rechercher un jeu dans la liste
        /// </summary>
        /// <param name="jeu">Le jeu à rechercher</param>
        /// <returns>True ou False</returns>
        public bool RechercheJeu(Jeu jeu)
        {
            return this.listeJeux.Contains(jeu);
        }

        /// <summary>
        /// Permet de rechercher un jeu dans la liste avec un nom
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Renvoie le jeu</returns>
        public Jeu RechercheJeuParNom(string n)
        {
            Jeu j = new Jeu();
            //for (int i = 0; i < this.listeJeux.Count(); i++)
            for (int i = 0; i < this.listeJeux.Count; i++)
            {
                if (this.listeJeux[i].Nom == n) j = this.listeJeux[i];
            }
            return j;
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
        /// Méthode qui permet de demander à l'utilisateur de saisir les informations de chaque jeux dans la liste
        /// </summary>
        public void Saisie()
        {
            foreach(Jeu jeu in listeJeux)
            {
                jeu.Saisie();
            }
        }

        /// <summary>
        /// Méthode qui permet d'afficher toutes les informations sur chaque jeu
        /// </summary>
        public void Affiche()
        {
            foreach(Jeu jeu in listeJeux)
            {
                jeu.Affiche();
            }
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
        /// Permet de trier la liste par ordre alphabétique des noms des Jeux (tri à bulles)
        /// </summary>
        public void Tri()
        {
            int size = listeJeux.Count;
            bool trie = false;
            do
            {

                for (int i = size; i > 1; --i)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (listeJeux[j].CompareTo(listeJeux[j + 1]) > 0)
                        {
                            Jeu temp = listeJeux[j];
                            listeJeux[j] = listeJeux[j + 1];
                            listeJeux[j + 1] = temp;
                        }
                    }
                }
            } while (trie);
        }

        public List<Jeu> ListeJeux { get => listeJeux; set => listeJeux = value; }

    }
}
