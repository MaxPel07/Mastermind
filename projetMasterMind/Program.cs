///ETML
///Auteur :      Maxime Pelloquin
///Date   :      22.09.2023
///Description : Ce programme est un jeu communément appelé MasterMind. L'ordinateur choisit aléatoirement une suite de 4 couleurs
///              et le joueur doit trouvé cette combinaison secrète en essayant plusieur combinaison. Le grogramme lui indique si
///              dans la combinaison qu'il a inséré il y a des couleurs de bien placé et des bonnes couleurs mais en mauvaise position.
///              Le joueur a le droit a 10 possibilités.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetMasterMind
{   
    internal class Program
    {
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            do
            {
                //Création des valeurs pour stocker les variables
                char[] goal = new char[4];
                string tryUser;
                //string rightCombination = "GGGG";

                //Message de Bienvenue sur la console, avec les explications du jeux.
                Console.WriteLine("Bienvenue sur Mastermind !");
                Console.WriteLine("Couleur possible : GYWRMC");
                Console.WriteLine("Devine le code en 4 couleur.\n");

                Random random = new Random();
                int color1 = random.Next(6);
                int color2 = random.Next(6);
                int color3 = random.Next(6);
                int color4 = random.Next(6);

                switch (color1)
                {
                    case 1:
                        goal[0] = 'R';
                        break;
                    
                    case 2:
                        goal[0] = 'G';
                        break;

                    case 3:
                        goal[0] = 'B';
                        break;

                    case 4:
                        goal[0] = 'Y';
                        break;

                    case 5:
                        goal[0] = 'M';
                        break;

                    case 6:
                        goal[0] = 'W';
                        break;

                    case 7:
                        goal[0] = 'C';
                        break;
                }

                switch (color2)
                {
                    case 1:
                        goal[1] = 'R';
                        break;

                    case 2:
                        goal[1] = 'G';
                        break;

                    case 3:
                        goal[1] = 'B';
                        break;

                    case 4:
                        goal[1] = 'Y';
                        break;

                    case 5:
                        goal[1] = 'M';
                        break;

                    case 6:
                        goal[1] = 'W';
                        break;

                    case 7:
                        goal[1] = 'C';
                        break;
                }

                switch (color3)
                {
                    case 1:
                        goal[2] = 'R';
                        break;

                    case 2:
                        goal[2] = 'G';
                        break;

                    case 3:
                        goal[2] = 'B';
                        break;

                    case 4:
                        goal[2] = 'Y';
                        break;

                    case 5:
                        goal[2] = 'M';
                        break;

                    case 6:
                        goal[2] = 'W';
                        break;

                    case 7:
                        goal[2] = 'C';
                        break;
                }

                switch (color4)
                {
                    case 1:
                        goal[3] = 'R';
                        break;

                    case 2:
                        goal[3] = 'G';
                        break;

                    case 3:
                        goal[3] = 'B';
                        break;

                    case 4:
                        goal[3] = 'Y';
                        break;

                    case 5:
                        goal[3] = 'M';
                        break;

                    case 6:
                        goal[3] = 'W';
                        break;

                    case 7:
                        goal[3] = 'C';
                        break;
                }

                //10 essaie possible avec comme réponse système "mauvaise réponse" ou "Bravo..." pour le moment
                //goal.char
                for (int nbEssaie = 1; nbEssaie < 11; nbEssaie++)
                {
                    Console.WriteLine("Essaie" + nbEssaie);
                    tryUser = Console.ReadLine();

                    /*
                    int ok = 0;
                    for (int i = 0; i < goal.Length; i++)
                    {
                        char goalChar = goal[i];
                        char tryUserChar = tryUser[i];

                        if((tryUser[i] == goal[i]))
                         
                        {
                            ok++;
                        }
                    }
                    */
                    int ok = 0;
                    
                        if (tryUser == goal.ToString())
                        {
                            Console.WriteLine("Bravo ! Vous avez trouvé la bonne combinaison");
                            break; //sort de la boucle si la combinaison est correcte
                        }
                        else 
                        {
                            if (tryUser[0] == goal[0])
                            {
                                ok = ok + 1;
                            }
                            if (tryUser[1] == goal[1])
                            {
                                ok = ok + 1;
                            }
                            if (tryUser[2] == goal[2])
                            {
                                ok = ok + 1;
                            }
                            if (tryUser[3] == goal[3])
                            {
                                ok = ok + 1;
                            }
                            Console.WriteLine("Bravo ! Vous avez trouvé"+ok+" bonnes couleurs la bonne combinaison");
                            break; //sort de la boucle si la combinaison est correcte
                        }
                    /*
                    else if (tryUser != goal.ToString())
                    {
                        Console.WriteLine("mauvaise réponse");
                    }*/

                }

                Console.WriteLine("Voulez-vous rejouer ? (Oui/Non)");
            } while (Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Appuyez sur une touche pour quitter le jeu");
            Console.ReadLine();

        }
    }
}
