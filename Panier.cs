using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace TPCDAA
{
    public class Panier<T> where T: IComparable<T>
    {
        private List<T> list; //liste élément de type T
        private const int max = 100;
        private int nbe; // nombre courant d'élément

        /// <summary>
        /// Construteur de la classe Element
        /// </summary>
        public Panier()
        {
            this.nbe = 0;
            this.list = new List<T>();
        }

        /// <summary>
        /// Permet d'ajout un élément à la liste T
        /// </summary>
        /// <param name="ele">L'élément à ajouter</param>
        public void ajout(T ele)
        {
            if (this.nbe < max && !appartient(ele)) this.list.Add(ele);

            else
                Console.WriteLine("le panier est plein.");
        }

        /// <summary>
        /// Permet de supprimer un élément de la liste T
        /// </summary>
        /// <param name="ele">L'élément à supprimer</param>
        public void suppression(T ele)
        {
            this.list.Remove(ele);
        }


        /// <summary>
        /// Permet de savoir si un élément appartient à la liste
        /// </summary>
        /// <param name="ele">L'élément à rechercher</param>
        /// <returns></returns>
        public bool appartient(T ele)
        {
            return this.list.Contains(ele);
        }

        /// <summary>
        /// Permet de trier les élements de la liste.
        /// </summary>
        public void Trier()
        {
            list.Sort();
            Afficher();
        }

        /// <summary>
        /// Permet d'afficher les éléments de la liste.
        /// </summary>
        public void Afficher()
        {
            foreach(T item in list)
            {
                Console.WriteLine(item);
            }
        }


    }
}
