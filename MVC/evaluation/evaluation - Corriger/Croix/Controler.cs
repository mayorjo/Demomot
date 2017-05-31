/*
* ETML
* Author : David Fisher
* Modifer : Jonathan Mayor
* Date : 31.05.17
* Summary : Programme qui permet d'afficher une croix suivant une valeur (structure MVC)
*/
using System;

namespace Croix
{
    class Controler
    {
        static void Main(string[] args)
        {
            Modele modele = new Modele();
            Vue vue = new Vue();

            if(modele.GetStatusIsModeleCreataed() == true || vue.GetStatusIsVueCreataed() == true)
            {
                //afficher le titre 
                vue.displaySomethingWriteLine(modele.getTitle());
                vue.displaySomethingWriteLine(modele.getUnderline());

                //affiche la question
                vue.displaySomethingWriteLine(modele.getQuestion());

                //récupere la valeur entré 
                modele.setIntCroix(Convert.ToInt16(Console.ReadLine()));

                //valide le chiffre 
                while(modele.isNumberValide(modele.getIntCroix()) == false)
                {
                    vue.displaySomethingWrite(modele.getError());
                    modele.setIntCroix(Convert.ToInt16(Console.ReadLine()));
                }

                

            }

            else
            {
                Console.WriteLine("problème de connection");
            }
            /*
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
            */
            Console.ReadLine();
            }

        }
    }

