/*
* ETML
* Author : Jonathan Mayor
* Date : 30.05.17
* Summary : Vue qui contient tout ce qui concerne l'affichage même les méthodes
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_403_mayorjo_Listedeclasse
{
    class Vue
    {
        //Variable
        public bool IsVueCreataed = false;

        //Constructeur 
        public Vue ()
        {
            IsVueCreataed = true;
        }

        //Méthode d'affichage
        public void displaySomethingWriteLine (string somethingToDisplay)
        {
            //Ecrit la valeur de la variable
            Console.WriteLine(somethingToDisplay);
        }

        public void displaySomethingWrite(string somethingToDisplay)
        {
            //Ecrit la valeur de la variable
            Console.Write(somethingToDisplay);
        }

    }
}
