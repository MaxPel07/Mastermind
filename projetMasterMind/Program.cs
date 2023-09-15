using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetMasterMind
{
    internal class Program
    {
        static void Main(string[] args) {
            //Création des valeurs pour stocker les variables
            string red;
            string green;
            string blue;
            string yellow;
            string magenta;
            string white;
            string cyan;
            string essaieutilisateur;
            string combinaisonJuste = "GGGG";

           //Message de Bienvenue sur la console, avec les explications du jeux.
            Console.WriteLine("Bienvenue sur Mastermind !");
            Console.WriteLine("Couleur possible : GYWRMC");
            Console.WriteLine("Devine le code en 4 couleur.\n");
            for (int nbEssaie = 1; nbEssaie < 11; nbEssaie++)
            {
                Console.WriteLine("Essaie" + nbEssaie);
                string essaieUtilisateur=Console.ReadLine();
                if (essaieUtilisateur == combinaisonJuste)
                {
                    Console.WriteLine("Bravo ! Vous avez trouvé la bonne combinaison");
                }
                else if (essaieUtilisateur != combinaisonJuste)
                {
                    Console.WriteLine("mauvaise réponse");
                }

            }

            Console.ReadLine();
        }

    }
}
