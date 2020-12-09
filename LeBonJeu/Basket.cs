using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Security;
using System.Text;

namespace LeBonJeu
{
    /// <summary>
    /// la classe Basket implémente l'interface IBasketElement pour la comparaison d'objes de type IBasketElement
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Basket<T> where T : IBasketElement
    {
        //Taille max ou limite du tableau
        private const int CAPACITY = 8;
        //Tableau d'éléments ou d'objets
        private T[] elements; 
        //Nombre d'éléments actuel dans le tableau
        private int size;

        /// <summary>
        /// Construteur de la classe Element
        /// </summary>
        public Basket()
        {
            this.size = 0;
            this.elements = new T[CAPACITY];
        }

        /// <summary>
        /// Méthode permettant d'insérer un élément dans le tableau
        /// Affiche une exception si size est égale ou supérieure à la taille du tableau
        /// </summary>
        /// <param name="element"></param>
        private void Insert(T element)
        {
            if(size>=CAPACITY)
            {
                throw new System.Exception("Basket's maximum capacity reached.");
            }
            elements[size++] = element;
        }

        
            

        /// <summary>
        /// Permet d'ajouter un élément à la liste T
        /// Vérifie si l'élément est déjà présent dans le tableau avant de l'insérer
        /// </summary>
        /// <param name="ele">L'élément à ajouter</param>
        public void InsertWithoutDuplicate(T element)
        {
            if(IndexOf(element)<0) Insert(element);
            else Console.WriteLine("Element already in basket.");
        }

        /// <summary>
        /// Ecrase l'élément qui se trouve à la position indexOfElementToRemove en décalant toutes les valeurs
        /// //Réduit size de 1 pour indiquer qu'un élément a été supprimé
        /// </summary>
        /// <param name="indexOfElementToRemove"></param>
        public void RemoveAt(int indexOfElementToRemove)
        {
            for (int i = indexOfElementToRemove; i < size - 1; ++i)
            {
                elements[i] = elements[i + 1];
            }
            --size;
        }
        

        /// <summary>
        /// Permet de supprimer un élément de la liste T
        /// </summary>
        /// <param name="ele">L'élément à supprimer</param>
        public void Remove(T element)
        {
            int indexOfElement = IndexOf(element);
            if (indexOfElement < 0) return;
            RemoveAt(indexOfElement);
        }


        /// <summary>
        /// Renvoie l'index de l'élément donné au sein de la collection si elle le contient.
        /// Renvoie -1 si l'élément ne fait pas parti de la collection.
        /// </summary>
        /// <param name="ele">L'élément à rechercher</param>
        /// <returns></returns>
        public int IndexOf(T element)
        {
            for(int indexOfElement = 0; indexOfElement < size; ++indexOfElement)
            {
                if (elements[indexOfElement].Equals(element))
                {
                    return indexOfElement;
                }
            }
            return -1;   
        }


        /// <summary>
        /// Tri à bulle permettant de comparer deux éléments du tableau et de les repositionner dans le tableau
        /// en fonction du résultat de la comparaison
        /// </summary>
        public void Sort()
        {
            int x = size;
            bool trie = false;
            do
            {

                for (int i = x; i > 1; --i)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (elements[j].CompareTo(elements[j + 1]) > 0)
                        {
                            var temp = elements[j];
                            elements[j] = elements[j + 1];
                            elements[j + 1] = temp;
                        }
                    }
                }
            } while (trie);
        }
        

        /// <summary>
        /// Permet d'afficher les éléments de la liste.
        /// </summary>
        public void Display()
        {
            foreach(T element in elements)
            {
                Console.WriteLine(element);
            }
        }


    }
}
