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
        static void Main(string[] args)
        {
            Console.WindowWidth = 50;
            Console.WindowHeight = 30;
            Console.BufferWidth = 50;
            Console.BufferHeight = 9001;

            do
            {
                char[] goal = new char[4];
                string tryUser;

                Console.Clear();
                Console.WriteLine("Bienvenue sur Mastermind !");
                Console.WriteLine("Couleurs possibles : GYWRMCB");
                Console.WriteLine("Devinez le code en 4 couleurs.\n");

                Random random = new Random();

                // Génération d'une combinaison aléatoire de 4 couleurs
                for (int i = 0; i < 4; i++)
                {
                    int colorValue = random.Next(6);
                    char color;

                    // Conversion de la valeur aléatoire en caractère de couleur
                    switch (colorValue)
                    {
                        case 0:
                            color = 'C';
                            break;
                        case 1:
                            color = 'R';
                            break;
                        case 2:
                            color = 'G';
                            break;
                        case 3:
                            color = 'B';
                            break;
                        case 4:
                            color = 'Y';
                            break;
                        case 5:
                            color = 'M';
                            break;
                        default:
                            color = 'W';
                            break;
                    }

                    goal[i] = color;
                }

                string code = new string(goal);

                // Affiche la bonne combinaison pour le moment, pour effectuer des tests
                Console.WriteLine("Bonne combinaison pour la verion test => " + code);
                Console.WriteLine(code);

                for (int nbTries = 1; nbTries <= 10; nbTries++)
                {
                    Console.WriteLine("Essai " + nbTries);
                    tryUser = Console.ReadLine();

                    int ok = 0;
                    int badPosition = 0;

                    List<char> correctButMisplaced = new List<char>();

                    // Comparaison entre la proposition de l'utilisateur et la combinaison secrète
                    if (tryUser == code)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Bravo ! Vous avez trouvé la bonne combinaison");
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < code.Length; i++)
                        {
                            if (tryUser[i] == code[i])
                            {
                                ok++;
                            }
                            else if (code.Contains(tryUser[i]) && !correctButMisplaced.Contains(tryUser[i]))
                            {
                                correctButMisplaced.Add(tryUser[i]);
                                badPosition++;
                            }
                        }
                        // Affichage du résultat de l'essai
                        Console.WriteLine("=> " + ok + " couleur(s) bien placée(s)");
                        Console.WriteLine("=> " + badPosition + " couleur(s) correcte(s) mais mal placée(s)");
                    }

                    if (tryUser != code)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mauvaise réponse");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("Voulez-vous rejouer ? (Oui/Non)");
                Console.WriteLine();
            } while (Console.ReadLine().Equals("Oui", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Appuyez sur la touche ENTER pour quitter le jeu");
            Console.ReadLine();
        }
    }
}
