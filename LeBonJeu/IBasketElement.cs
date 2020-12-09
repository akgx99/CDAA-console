using System;
using System.Collections.Generic;
using System.Text;

namespace LeBonJeu
{
    public interface IBasketElement : 
        // Tous les classes qui implémentent IBasketElement sont comparables entre elles :
        IComparable<IBasketElement>
    {
        /// <summary>
        /// Méthode de l'interface qui permet de récupérer le nom de différentes classes et de les comparer
        /// </summary>
        /// <returns></returns>
        string GetName();
    }
}
