using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonJeu
{
    /// <summary>
    /// Classe représentant le Catalogue du magasin
    /// </summary>
    class Catalogue
    {
        private DateTime dateMAJ;
        private LesJeux lj;
        private LesFigurines lf;

        /// <summary>
        /// Constructeur de la classe Catalogue qui contient des jeux
        /// </summary>
        /// <param name="lj">La liste des Jeu</param>
        public Catalogue(LesJeux lj)
        {
            this.dateMAJ = DateTime.Today;
            this.lj = lj;
        }

        public Catalogue()
        {
            this.dateMAJ = DateTime.Today;
            this.lj = new LesJeux();
            this.lf = new LesFigurines();

        }

        public Catalogue(LesFigurines lf)
        {
            this.dateMAJ = DateTime.Today;
            this.lf = lf;
        }

        /// <summary>
        /// Permet d'ajouter un Jeu de la liste
        /// </summary>
        /// <param name="j">Le jeu à ajouter</param>
        public void AjouterJeu(Jeu j)
        {
            lj.AjouterJeu(j);
        }

        public void AjouterFigurine(Figurine f)
        {
            lf.Ajouter(f);
        }

        /// <summary>
        /// Permet de supprimer un jeu de la liste
        /// </summary>
        /// <param name="j">Le jeu à supprimer</param>
        public void SupprimerJeu(Jeu j)
        {
            lj.SupprimerJeu(j);
        }

        public void SupprimerFigurine(Figurine f)
        {
            lf.Supprimer(f);
        }

        /// <summary>
        /// Permet de rechercher un jeu
        /// </summary>
        /// <param name="j">Le jeu à rechercher</param>
        /// <returns>True ou False</returns>
        public bool RechercherJeu(Jeu j)
        {
            return lj.RechercheJeu(j);
        }

        public bool RechercherFigurine(Figurine f)
        {
            return lf.RechercherFigurine(f);
        }

        /// <summary>
        /// Permet d'afficher les informations de chaque jeu du Catalogue
        /// </summary>
        public void AfficheCatalogueJeu()
        {
            lj.Affiche();
        }

        public void AfficheCatalogueFigurine()
        {
            lf.Affiche();
        }

        public DateTime DateMAJ { get => dateMAJ; set => dateMAJ = value; }
        public LesJeux Lj { get => lj; set => lj = value; }
        internal LesFigurines Lf { get => lf; set => lf = value; }
    }
}
