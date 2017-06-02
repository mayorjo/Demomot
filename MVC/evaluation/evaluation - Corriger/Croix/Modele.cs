/*
* ETML
* Author : Jonathan Mayor
* Date : 31.05.17
* Summary : Modèle qui les variables et méthode de la croix 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Croix
{
    class Modele
    {
        //Variables
        private int intCroix = '0';
        private int intespace = '0';
        private bool IsModeleCreataed = false;

        //Constante du titre
        private const string title = "Affichage d'une croix et de sa valeur";
        private const string underline = "-------------------------------------\n\n";

        //Constante de la question
        private const string question = "Entrez une valeur comprise entre 4 et 9 (y.c.) :  ";

        //Constante en cas d'erreur
        private const string error = "Invalide entrez à nouveaux : ";

        //Constante espace
        private const char space = ' ';

        /// <summary>
        /// Constructeur de modele 
        /// </summary>
        public Modele ()
        {
            IsModeleCreataed = true;
        }


        /// <summary>
        /// Méthode qui permet d'avoir le status de l'objet Modele
        /// </summary>
        /// <returns>une variable bool qui permet de savoir si l'objet est créé</returns>
        public bool GetStatusIsModeleCreataed()
        {
            return IsModeleCreataed;
        }

        /// <summary>
        /// Méthode qui permet de valider un chiffre entre 4-9
        /// </summary>
        /// <param name="number">chiffre à valider</param>
        /// <returns>variable bool</returns>
        public bool isNumberValide (int number)
        {
            if(intCroix < 4 || intCroix > 9)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Get - Set
        /*
        Le getter permet d'avoir la valeur de la variable         
        Le setter permet de mettre en place une valeur à une variable
        */

        /// <summary>
        /// setter intCroix
        /// </summary>
        /// <param name="number">valeur à mettre en place</param>
        public void setIntCroix (int number)
        {
            intCroix = number;
        }

        /// <summary>
        /// setter intEspace
        /// </summary>
        /// <param name="number">valeur à mettre en place</param>
        public void setIntespace(int number)
        {
            intespace = number;
        }

        /// <summary>
        /// getter titre
        /// </summary>
        /// <returns>le titre</returns>
        public string getTitle()
        {
            return title;
        }

        /// <summary>
        /// getter underline
        /// </summary>
        /// <returns>underline</returns>
        public string getUnderline()
        {
            return underline;
        }

        /// <summary>
        /// getter question
        /// </summary>
        /// <returns>question</returns>
        public string getQuestion()
        {
            return question;
        }

        /// <summary>
        /// getter error
        /// </summary>
        /// <returns>message d'erreur</returns>
        public string getError()
        {
            return error;
        }

        /// <summary>
        /// getter space
        /// </summary>
        /// <returns>Un espace</returns>
        public char getSpace()
        {
            return space;
        }

        /// <summary>
        /// getter IntCroix
        /// </summary>
        /// <returns>la valeur de IntCroix</returns>
        public int getIntCroix()
        {
            return intCroix;
        }

    }
}
