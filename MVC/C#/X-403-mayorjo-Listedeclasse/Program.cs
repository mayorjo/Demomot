/*
* ETML
* Author : Jonathan Mayor
* Date : Oula
* Summary : Programme qui écrit les données d'un tableau
*/
using System;

namespace X_403_mayorjo_Listedeclasse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tableau 
            string[] names = new string[15] {"Balmori", "Colombo", "Dos Santos", "Foot"/*RIP*/, "Gomes", "Guggisberg", "Lopez", "Mayor", "Poget", "Santos Oliveira", "Thomas", "Vallecillos", "Wassenberg", "Pache", "Pittier"};

            //Foreach qui permet d'écrire les données du tableau 
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
