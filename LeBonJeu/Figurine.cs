using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeBonJeu 
{
    /// <summary>
    /// Classe représentant une figurine
    /// </summary>

    /// CLASSE PERSO ///
    public class Figurine : IComparable<Figurine>
    {
        private String nom;
        private String description;
        private MarqueFigurine marque; //enum 
        private float prix;
        private DateTime dateS;
        private Image photo;


        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Figurine()
        {
            this.nom = "";
            this.description = "";
            this.marque =MarqueFigurine.UneFigurine;
            this.prix = 0;
            dateS = new DateTime();
        }

        /// <summary>
        /// Constructeur avec paramètres
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="description"></param>
        /// <param name="marque"></param>
        /// <param name="prix"></param>
        /// <param name="dateS"></param>
        /// <param name="photo"></param>
        public Figurine(string nom, string description, MarqueFigurine marque, float prix, DateTime dateS)
        {
            this.nom = nom;
            this.description = description;
            this.marque = marque;
            this.prix = prix;
            this.dateS = dateS;
        }

        public string MarqueS
        {
            get { return Enum.Format(typeof(MarqueFigurine), this.Marque, "g"); }
            set
            {
                try
                {
                    this.Marque = (MarqueFigurine)Enum.Parse(typeof(MarqueFigurine), value, false);
                }
                catch (System.ArgumentException e)
                {
                    Console.WriteLine("ArgumentException : {0}", e.Message);
                }
            }
        }

        /// <summary>
        /// Méthode de l'interface Icomparable qui permet ici de comparé des Figurines 
        /// </summary>
        /// <param name="other">L'autre figurine à comparer</param>
        /// <returns>Un entier représentant le résultat de la comparaison</returns>
        public int CompareTo(Figurine other)
        {
            if (other == null) return 1;

            return nom.CompareTo(other.nom);
        }

        /// <summary>
        /// Permet de dire si une figurine est inférieur (alphabétiquement par rapport à son Nom) à un autre.
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator <(Figurine left, Figurine right)
        {
            return left.Nom.CompareTo(right.Nom) < 0;
        }

        /// <summary>
        /// Permet de dire si une figurine est inférieur ou égal (alphabétiquement par rapport à son Nom) à un autre.
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator <=(Figurine left, Figurine right)
        {
            return left.Nom.CompareTo(right.Nom) <= 0;
        }

        /// <summary>
        /// Permet de dire si une figurine est supérieur ou égal (alphabétiquement par rapport à son Nom) à un autre.
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator >=(Figurine left, Figurine right)
        {
            return left.Nom.CompareTo(right.Nom) >= 0;
        }

        /// <summary>
        /// Permet de dire si une figurine est supérieur (alphabétiquement par rapport à son Nom) à un autre.
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator >(Figurine left, Figurine right)
        {
            return left.Nom.CompareTo(right.Nom) > 0;
        }

        /// <summary>
        /// Surcharge de la méthode Equals
        /// </summary>
        /// <param name="other">L'objet à comparé</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Figurine objAsJeu = obj as Figurine;
            if (objAsJeu == null)
                return false;
            else
                return Equals(objAsJeu);
        }

        /// <summary>
        /// Permet de dire si une figurine est égal à une autre
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public bool Equals(Figurine other)
        {
            if (other == null) return false;
            return (this.Nom.Equals(other.Nom));
        }

        /// <summary>
        /// Permet de dire si und figurine est égale à une autre
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator ==(Figurine fig1, Figurine fig2)
        {
            if ((Object)fig1 == null) return (Object)fig2 == null;
            return fig1.Equals(fig2);
        }

        /// <summary>
        /// Permet de dire si une figurine n'est pas égale (alphabétiquement par rapport à son Nom) à un autre
        /// </summary>
        /// <returns>True ou False : le résultant de la comparaison</returns>
        public static bool operator !=(Figurine fig1, Figurine fig2)
        {
            return !(fig1 == fig2);
        }


        /// <summary>
        /// Permet la saisie par l'utilisateur des informations d'une Figurine.
        /// </summary>
        public virtual void saisie()
        {
            Console.WriteLine("=============== Saisie ===============\n\r" +
                              "======================================\n\r");

            Console.WriteLine("Nom ?");
            this.nom = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Description ?");
            this.description = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Marque ?");
            this.MarqueS = Console.ReadLine();
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
        /// Affiche les informations d'une figurine
        /// </summary>
        public virtual void affiche()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// ToString de figuirne
        /// </summary>
        /// <returns>Les informations d'une figurine</returns>
        public override string ToString()
        {
            string s = "";

            s += "===============" + this.nom + "===============\n\r";

            s += "\n\r Date de sortie : " + this.dateS + "\n\r";

            s += "\n\r Description : " + this.description + "\n\r";

            s += "\n\r Genre : " + this.marque + "\n\r";

            s += "\n\r Prix : " + this.prix + "\n\r";

            return s;
        }

        /// <summary>
        /// Donne le hashcode de la classe (recommandé d'être présent lorsque l'on override Equals et donc utilise == et !=)
        /// </summary>
        /// <returns>Le hashcode de la classe jeu à partir de Nom</returns>
        public override int GetHashCode()
        {
            return nom.GetHashCode();
        }



        //getter setter
        public string Nom { get => nom; set => nom = value; }
        public string Description { get => description; set => description = value; }
        public MarqueFigurine Marque { get => marque; set => marque = value; }
        public float Prix { get => prix; set => prix = value; }
        public Image Photo { get => photo; set => photo = value; }
        public DateTime DateS { get => dateS; set => dateS = value; }
    }
}
