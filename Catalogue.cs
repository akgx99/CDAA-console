using System;
using System.Collections.Generic;
using System.Text;

namespace TPCDAA
{
    /// <summary>
    /// Classe représentant le Catalogue du magasin
    /// </summary>
    class Catalogue
    {
        private DateTime dateMAJ;
        private LesJeux lj;

        /// <summary>
        /// Constructeur de la classe Catalogue
        /// </summary>
        /// <param name="lj">La liste des Jeu</param>
        public Catalogue(LesJeux lj)
        {
            this.dateMAJ = DateTime.Today;
            this.lj = lj;
        }

        /// <summary>
        /// Permet d'ajouter un Jeu
        /// </summary>
        /// <param name="j">Le jeu à ajouter</param>
        public void ajouterJeu(Jeu j)
        {
            lj.AjouterJeu(j);
        }

        /// <summary>
        /// Permet de supprimer un jeu
        /// </summary>
        /// <param name="j">Le jeu à supprimer</param>
        public void supprimerJeu(Jeu j)
        {
            lj.supprimerJeu(j);
        }

        /// <summary>
        /// Permet de rechercher un jeu
        /// </summary>
        /// <param name="j">Le jeu à rechercher</param>
        /// <returns>True ou False</returns>
        public bool rechercherJeu(Jeu j)
        {
            return lj.rechercheJeu(j);
        }

        //property
        public DateTime DateMAJ { get => dateMAJ; set => dateMAJ = value; }
        public LesJeux Lj { get => lj; set => lj = value; }
    }
}
