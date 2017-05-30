/*
* ETML
* Author : Jonathan Mayor
* Date : 30.05.17
* Summary : Modèle qui contient les données, les méthodes, etc. 
*/

namespace X_403_mayorjo_Listedeclasse
{
    class Modele
    {
        //Variables
        public bool IsModeleCreataed = false;

        //Tableau 
        string[] names = new string[15] { "Balmori", "Colombo", "Dos Santos", "Foot"/*RIP*/, "Gomes", "Guggisberg", "Lopez", "Mayor", "Poget", "Santos Oliveira", "Thomas", "Vallecillos", "Wassenberg", "Pache", "Pittier" };

        //Constructeur
        public Modele()
        {
            IsModeleCreataed = true;
        }

        //Methode 
        public string getNameFromTable (byte placeName)
        {
            //recherche le nom correspondant à la place donnée  
            string name = names[placeName];

            //retourne le nom
            return name;
        }

    }
}
