using System;

namespace TPCDAA
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialisation d'un set de jeu
            LesJeux lj = new LesJeux();
            lj.init();

            //affichage des jeux de la liste
            Console.WriteLine("\n\rAffichage jeu : ");
            Console.WriteLine(lj);

            Console.WriteLine("\n\rAffichage jeu trié : ");

            // tri et affichage des jeux
            lj.Tri();
            Console.WriteLine(lj);

            //recherche d'un jeu
            Console.WriteLine("\n\rRecheche d'un jeu : ");
            Console.WriteLine("Jeu en position 0 dans la liste : "+lj.rechercheJeu(lj.ListeJeux[0]));

            //recherche des jeux retro
            Console.WriteLine("\n\rRecheche des jeux retros : ");
            foreach(JeuRetro j in lj.RechercheJeuRetro())
            {
                Console.WriteLine(j);
            }

            //supression d'un jeu
            Console.WriteLine("\n\rSupression d'un jeu  : ");
            lj.supprimerJeu(lj.ListeJeux[0]);
            Console.WriteLine(lj);


            //utilisation du panier
            LesJeux lj2 = new LesJeux();
            lj2.init();
            Panier<Jeu> jeux = new Panier<Jeu>();

            //ajout des jeux au panier 
            foreach(Jeu j in lj2.ListeJeux)
            {
                jeux.ajout(j);
            }

            //recherche des jeux dans le panier
            Console.WriteLine("\n\rRecherche d'un jeu dans le panier  : ");
            Console.WriteLine("Test de la présence d'un jeu dans le panier : " + jeux.appartient(lj.ListeJeux[0]));

            //supression d'un jeu dans le panier
            Console.WriteLine("\n\rSupression d'un jeu dans le panier  : ");
            jeux.suppression(lj.ListeJeux[0]);
            Console.WriteLine("Test de la présence d'un jeu dans le panier : " + jeux.appartient(lj.ListeJeux[0]));

            //tri du panier
            Console.WriteLine("\n\rTri du panier  : ");
            jeux.Trier();

            Console.ReadLine();

        }
    }
}
