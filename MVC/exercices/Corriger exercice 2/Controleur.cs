/*
* ETML
* Author : Jonathan Mayor
* Date : 30.05.17
* Summary : Controleur qui fait le lien avec le modèle et la vue et tout le reste
*/
using System;

namespace X_403_mayorjo_Listedeclasse
{
    class Controleur
    {
        static void Main(string[] args)
        {
            //Création des objets Vue et Modele
            Modele modele = new Modele();
            Vue vue = new Vue();

            /*//Retourne le status des 2 objet pour savoir s'ils sont créés
            //Exception à la règle pour les afficher ;)
            Console.WriteLine("Est-ce que le modèle est créé ? " + modele.GetStatusIsModeleCreataed());
            Console.WriteLine("Est-ce que la vue est créée ? " + vue.GetStatusIsVueCreataed());
            */

            //if: Si la connexion entre les objets est bonne 
            if (modele.GetStatusIsModeleCreataed() == true || vue.GetStatusIsVueCreataed() == true)
            {
                //Boucle qui permet d'afficher les membres d'un tableau
                for (int i = 0; i < modele.getTableNameLenght(); i++)
                {
                    //Permet d'afficher le nom de famille qui vient d'un tableau
                    vue.displaySomethingWriteLine(modele.getNameFromTable(i));
                }
            }
            //endif

            //else: dit qu'il y a un problème de connexion
            else
            {
                Console.WriteLine("Problème à quelque part !");
            }

            Console.ReadLine();
        }
    }
}
