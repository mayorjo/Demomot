/*
* ETML
* Author : Jonathan Mayor
* Date : 30.05.17
* Summary : Vue qui contient tout ce qui concerne l'affichage même les méthodes
*/
using System;

namespace Croix
{
    class Vue
    {
        //Variable
        private bool IsVueCreataed = false;

        /// <summary>
        /// Constructeur de la vue
        /// </summary>
        public Vue()
        {
            IsVueCreataed = true;
        }

        //Méthode d'affichage

        /// <summary>
        /// Méthode qui permet d'afficher un contenu donné + retour à la ligne
        /// </summary>
        /// <param name="somethingToDisplay">donnée à écrire</param>
        public void displaySomethingWriteLine(string somethingToDisplay)
        {
            //Ecrit la valeur de la variable
            Console.WriteLine(somethingToDisplay);
        }

        /// <summary>
        /// Méthode qui permet d'afficher un contenu donné
        /// </summary>
        /// <param name="somethingToDisplay">donnée à écrire</param>
        public void displaySomethingWrite(string somethingToDisplay)
        {
            //Ecrit la valeur de la variable
            Console.Write(somethingToDisplay);
        }

        /// <summary>
        /// Méthode qui permet d'avoir le status de l'objet vue
        /// </summary>
        /// <returns>une variable bool qui permet de savoir si l'objet est créé</returns>
        public bool GetStatusIsVueCreataed()
        {
            return IsVueCreataed;
        }
    }
}
