using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu
{
    /// <summary>
    /// Classe représentant un jeu.
    /// </summary>
    public class Jeu : IBasketElement
    {
        private string nom;
        private string description;
        private string editeur;
        private string plateforme;
        private CategorieGenre genre;
        private float prix;
        //date de sortie du jeu
        private DateTime dateS;
        private bool record;
        private Image photo;

        /// <summary>
        /// Construteur par défaut
        /// </summary>
        public Jeu()
        {
            this.nom = "";
            this.description = "";
            this.editeur = "";
            this.plateforme = "";
            this.genre = CategorieGenre.Autre;
            this.prix = 0;
            this.dateS = new DateTime();
            this.record = false;
        }
            

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="nom">Le Nom du jeu.</param>
        /// <param name="description">La Description du jeu.</param>
        /// <param name="editeur">L'éditeur du jeu.</param>
        /// <param name="plateforme">La platforme du jeu.</param>
        /// <param name="genre">Le genre du jeu.</param>
        /// <param name="prix">Le Prix du jeu.</param>
        /// <param name="dateS">La date de sortie du jeu.</param>
        /// <param name="record">L'enregistrement du jeu dans la BD.</param>
        public Jeu(string nom, string description, string editeur, string plateforme, CategorieGenre genre, float prix, DateTime dateS, bool record)
        {
            this.nom = nom;
            this.description = description;
            this.editeur = editeur;
            this.plateforme = plateforme;
            this.genre = genre;
            this.prix = prix;
            this.dateS = dateS;
            this.record = record;
        }
            

        /// <summary>
        /// Permet la saisie par l'utilisateur des informations d'un jeu.
        /// </summary>
        public virtual void Saisie()
        {
            Console.WriteLine("=============== Saisie Jeu ===============\n\r" +
                              "======================================\n\r");

            Console.WriteLine("Nom ?");
            this.nom = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Description ?");
            this.description = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Genre ?");
            GenreS = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Editeur ?");
            this.editeur = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Plateforme ?");
            this.plateforme = Console.ReadLine();
            Console.WriteLine("\n\r");

            try
            {
                string s;
                Console.WriteLine("Prix ?");
                s = Console.ReadLine();
                this.prix = Single.Parse(s);
                Console.WriteLine("\n\r");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("FormatException : {0}", e.Message);
            }

        }

        /// <summary>
        /// Affiche les informations d'un jeu
        /// </summary>
        public virtual void Affiche()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Donne le hashcode de la classe (recommandé d'être présent lorsque l'on override Equals et donc == et !=)
        /// </summary>
        /// <returns>Le hashcode de la classe jeu à partir de Nom</returns>
        public override int GetHashCode()
        {
            return nom.GetHashCode();
        }

        /// <summary>
        /// Méthode de l'interface Icomparable qui permet ici de comparer des Jeux 
        /// </summary>
        /// <param name="other">L'autre jeu à comparé</param>
        /// <returns>Un entier représentant le résultat de la comparaison</returns>
        public int CompareTo(Jeu other)
        {
            if (other == null) return 1;

            return Nom.CompareTo(other.Nom);
        }

        
        /// <summary>
        /// Permet de dire si un jeu est supérieur (alphabétiquement par rapport à son Nom) à un autre.
        /// </summary>
        /// <param name="jeu1">Le premier jeu à comparé</param>
        /// <param name="jeu2">Le deuxième jeu à comparé</param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator >(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.Nom.CompareTo(jeu2.Nom) == 1;
        }

        /// <summary>
        /// Permet de dire si un jeu est inférieur (alphabétiquement par rapport à son Nom) à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator <(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.Nom.CompareTo(jeu2.Nom) == -1;
        }

        /// <summary>
        /// Permet de dire si un jeu est inférieur ou égal (alphabétiquement par rapport à son Nom) à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator <=(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.Nom.CompareTo(jeu2.Nom) <= 0;
        }

        /// <summary>
        /// Permet de dire si un jeu est supérieur ou égal (alphabétiquement par rapport à son Nom) à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator >=(Jeu jeu1, Jeu jeu2)
        {
            return jeu1.Nom.CompareTo(jeu2.Nom) >= 0;
        }

        /// <summary>
        /// Surcharge de la méthode Equals
        /// </summary>
        /// <param name="other">L'objet à comparer</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            
            Jeu objAsJeu = obj as Jeu;
            if (objAsJeu == null) 
                return false;
            else 
                return Equals(objAsJeu);
        }

        /// <summary>
        /// Permet de dire si un jeu est égal à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public bool Equals(Jeu other)
        {
            if (other == null) return false;
            return (this.Nom.Equals(other.Nom));
        }

        /// <summary>
        /// Permet de dire si un jeu est égal à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator ==(Jeu jeu1, Jeu jeu2)
        {
            if ((Object) jeu1 == null) return (Object) jeu2 == null;
            return jeu1.Equals(jeu2);
        }

        /// <summary>
        /// Permet de dire si un jeu n'est pas égal (alphabétiquement par rapport à son Nom) à un autre
        /// </summary>
        /// <param name="jeu1"></param>
        /// <param name="jeu2"></param>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator !=(Jeu jeu1, Jeu jeu2)
        {
            return !(jeu1 == jeu2);
        }

        /// <summary>
        /// ToString de Jeu
        /// </summary>
        /// <returns>Les informations du Jeu</returns>
        public override string ToString()
        {
            string s = "";

            s += "===============" + this.nom + "===============\n\r";

            s += "\n\r Description : " + this.description + "\n\r";

            s += "\n\r Genre : " + this.genre + "\n\r";

            s += "\n\r Editeur : " + this.editeur + "\n\r";

            s += "\n\r Plateforme : " + this.plateforme + "\n\r";

            s += "\n\r Prix : " + this.prix + "\n\r";

            return s;
        }

        string IBasketElement.GetName()
        {
            return nom;
        }

        int IComparable<IBasketElement>.CompareTo(IBasketElement other)
        {
            if (other == null) return 1;

            return Nom.CompareTo(other.GetName());
        }

        // Property
        public string GenreS
        {
            get { return Enum.Format(typeof(CategorieGenre), this.Genre, "g"); }
            set {
                try
                {
                    this.Genre = (CategorieGenre)Enum.Parse(typeof(CategorieGenre), value, false);
                }
                catch (System.ArgumentException e)
                {
                    Console.WriteLine("ArgumentException : {0}", e.Message);
                }
            }
        }
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public string Plateforme { get => plateforme; set => plateforme = value; }
        public CategorieGenre Genre { get => genre; set => genre = value; }
        public float Prix { get => prix; set => prix = value; }
        public DateTime DateS { get => dateS; set => dateS = value; }
        public bool Record { get => record; set => record = value; }
        public Image Photo { get => photo; set => photo = value; }
    }
}
