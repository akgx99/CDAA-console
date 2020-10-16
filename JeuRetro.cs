using System;
using System.Collections.Generic;
using System.Text;

namespace TPCDAA
{
    /// <summary>
    /// Classe réprésentant un jeuRetro
    /// </summary>
    public class JeuRetro : Jeu
    {
        private string etat;
        private bool notice;
        //private List<Image> lphotos;

        /// <summary>
        /// Constructeur par défaut du JeuRetro
        /// </summary>
        public JeuRetro() : base()
        {
            this.etat = "";
            this.notice = false;
            //this.lphotos = new List<Image>();
        }

        /// <summary>
        /// Constructeur avec paramètre du JeuRétro
        /// </summary>
        /// <param name="etat">L'état du JeuRetro</param>
        /// <param name="notice">La préscence d'une notice avec le JeuRetro</param>
        /// <param name="nom">Le Nom du JeuRetro</param>
        /// <param name="description">La Description du JeuRetro</param>
        /// <param name="editeur">L'éditeur du JeuRetro</param>
        /// <param name="plateforme">La plateforme du JeuRetro</param>
        /// <param name="genre">Le genre du jeuRetro</param>
        /// <param name="prix">Le Prix du JeuRetro</param>
        /// <param name="dateS">La date de sortie du jeuRetro</param>
        /// <param name="record">L'enregistrement du jeuRetro dans la BD</param>
        public JeuRetro(string etat, bool notice, string nom, string description, string editeur, string plateforme, CategorieGenre genre, float prix, DateTime dateS, bool record) : base(nom, description, editeur, plateforme, genre, prix, dateS, record)
        {
            this.etat = etat;
            this.notice = notice;
        }

        /// <summary>
        /// Permet la saisie par l'utilisateur des informations d'un jeuRetro.
        /// </summary>
        public override void saisie()
        {
            base.saisie();

            Console.WriteLine("Etat ?");
            this.etat = Console.ReadLine();
            Console.WriteLine("\n\r");

            Console.WriteLine("Notice ?");
            string s = Console.ReadLine();
            this.notice = Convert.ToBoolean(s);
            Console.WriteLine("\n\r");
        }

        /// <summary>
        /// Permet la saisie par l'utilisateur des informations d'un jeu.
        /// </summary>
        public override void affiche()
        {
            base.affiche();
        }

        /// <summary>
        /// ToString jeuRetro
        /// </summary>
        /// <returns>Le toString du jeuRetro</returns>
        public override string ToString()
        {
            string notice = "non";

            if(this.notice){ notice = "oui"; }

            return base.ToString() +
                "\n\r Etat : " + this.etat + "\n\r" +
                "\n\r Notice : " + notice + "\n\r";
        }

        //prototype
        public string Etat { get => etat; set => etat = value; }
        public bool Notice { get => notice; set => notice = value; }

    }

}
