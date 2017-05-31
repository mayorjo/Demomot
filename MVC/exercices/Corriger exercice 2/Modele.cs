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

        /// <summary>
        /// Constructeur du modèle
        /// </summary>
        public Modele()
        {
            IsModeleCreataed = true;
        }

        //Méthode 

        /// <summary>
        /// Méthode qui retourne une variable du tableau 
        /// </summary>
        /// <param name="position">La position de la vaiable voulue</param>
        /// <returns></returns>
        public string getNameFromTable (int position)
        {
            //recherche le nom correspondant à la position donnée  
            string name = names[position];

            //retourne le nom
            return name;
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
        /// Méthode qui permet de retourner la longeur du tableau
        /// </summary>
        /// <returns>longueur du tableau</returns>
        public int getTableNameLenght()
        {
            //récupère la taille du tableau
            int tableLenght = names.Length;

            //retourne la dimension 
            return tableLenght;
        }
    }
}
