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

                /* Création de la croix */

                //Boucle qui permet de faire les lignes 
                for(int line = 1; line <= modele.getIntCroix(); line++)
                {
                    //Boucle qui permet d'afficher les caractères 
                    for(int caracter = 1; caracter <= modele.getIntCroix(); caracter++)
                    {
                        //Affiche le chiffre si les conditions sont remplies
                        if (line == caracter || caracter <= modele.getIntCroix() + 1)
                        {
                            vue.displaySomethingWrite(Convert.ToString(modele.getIntCroix()));
                        }

                        //Sinon affiche un espace 
                        else
                        {
                            vue.displaySomethingWrite(Convert.ToString(modele.getSpace()));
                        }
                    }
                    //Fait un retour à la ligne à la fin de la boucle 
                    vue.displaySomethingWriteLine("");
                }
                
            }

            //Affiche une information à l'utilisateur en cas de problème
            else
            {
                Console.WriteLine("problème de connection");
            }

            Console.ReadLine();
            }

        }
    }

