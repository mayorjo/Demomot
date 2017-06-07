
namespace StateMachineGUI
{
    public class Controler
    {
        //Variable Objet
        Modele modele;

        /// <summary>
        /// Constructeur de l'objet Controler
        /// </summary>
        public Controler()
        {
            //Création d'un objet modele à la création du controleur
            Modele modele = new Modele();

            //Join le modèle créé dans le constructeur avec celui qui local
            this.modele = modele;
        }

        /// <summary>
        /// Méthode qui appel la méthode "updateProgress" qui se trouve dans le modele
        /// </summary>
        /// <param name="incremente">variable bool en cas d'incrment</param>
        /// <param name="value">l'ancienne valeur de la PB</param>
        /// <returns>la nouvelle valeur de la pb</returns>
        public int updatePbRemaining(bool incremente, int value)
        {
            //retourne la nouvelle valeur de la PB
            return modele.updateProgress(incremente, value);
        }

        /// <summary>
        /// Méthode qui appel la méthode "updateProgressValue" qui se trouve dans le modele
        /// </summary>
        /// <param name="value">la valeur de la PB</param>
        /// <returns>la nouvelle valeur de du label</returns>
        public string updateLbProgress(int value)
        {
            //Retourne la nouvelle valeur du label
            return modele.updateProgressValue(value);
        }

        /// <summary>
        /// Méthode qui fait fait appel à la méthode "updateStateValue" qui se trouve dans el modele
        /// </summary>
        /// <param name="value">la valeur de la PB</param>
        /// <returns>la nouvelle valeur du "State"</returns>
        public int updateState(int value)
        {
            return modele.updateStateValue(value);
        }
    }
}
