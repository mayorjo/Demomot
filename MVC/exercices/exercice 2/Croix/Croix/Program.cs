using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            int intCroix = '0';
            int intespace = '0';
            //Affichage du titre
            Console.WriteLine("Affichage d'une croix et de sa valeur");
            Console.WriteLine("-------------------------------------\n\n");
            //Entrer de la valeur Croix
            Console.Write("Entrez une valeur comprise entre 4 et 9 (y.c.) : ");
            intCroix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Vérification si c'est entre 4 et 9
            while (intCroix < 4 || intCroix > 9)
            {
                Console.Write("Invalide entrez à nouveaux :");

                intCroix = Convert.ToInt32(Console.ReadLine());
            }

            for (int ligne = 1; ligne <= intCroix; ++ligne)
            {
                for (int caractere = 1; caractere <= intCroix; ++caractere)
                {
                    if (ligne == caractere || caractere == intCroix - ligne + 1)
                    {
                        Console.Write(intCroix);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            }

        }
    }

