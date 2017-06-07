/*
* ETML
* Auteur : Jonathan Mayor
* Date : 07.06.2017
* Summary : Modèle - Lieu ou on stock les variables, les méthodes, etc.  
*/

namespace StateMachineGUI
{
    public class Modele
    {
        /// <summary>
        /// Constructeur de l'objet Modele
        /// </summary>
        public Modele()
        {

        }

        //Variable
        private int valuePbRemaining = 0;
        private string valueLbProgress = "";

        /* Méthodes */

        /// <summary>
        /// Méthode qui permet d'incrémenter une valeur ou de décrémenter la valeur suivant une paramètre
        /// </summary>
        /// <param name="up">incrmémentation ?</param>
        /// <param name="value"> ancienne valeur de la PB </param>
        /// <returns></returns>
        public int updateProgress(bool up, int value)
        {
            if (up && value < 100)
            {
                value++;
            }
            else if (!up && value > 0)
            {
                value--;
            }

            return value;
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour la valeur du Label (lb) ProgressValue
        /// </summary>
        /// <param name="value">valeur de la PB</param>
        /// <returns></returns>
        public string updateProgressValue(int value)
        {
            return value + " %";
        }

        /// <summary>
        /// Méthode qui permet de mettre à jour la valeur State
        /// </summary>
        /// <param name="value">Valeur de la PB</param>
        /// <returns></returns>
        public int updateStateValue(int value)
        {
            return value = value / 5;
        }

        /* Get - set : ValuePbRemaining */
        /// <summary>
        /// Mise à jour de la valeur valuePbRemaining
        /// </summary>
        /// <param name="value">Nouvelle valeur</param>
        public void setValuePbRemaining (int value){ this.valuePbRemaining = value; }
        /// <summary>
        /// Reprise de la valeur valuePbRemaining
        /// </summary>
        /// <returns>retourne la valeur de valuePbRemaining</returns>
        public int getValuePbRemaining () { return valuePbRemaining; }

        /* Get - set : valueLbProgress */
        /// <summary>
        /// Mise à jour de la valeur valueLbProgress
        /// </summary>
        /// <param name="value">la nouvelle valeur</param>
        public void setvalueLbProgress(string value) { this.valueLbProgress = value; }
        /// <summary>
        /// Reprise de la valeur valueLbPregress
        /// </summary>
        /// <returns>la valeur de valueLbProgress</returns>
        public string getvalueLbProgress() { return valueLbProgress; }
    }
}
