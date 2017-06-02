using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineGUI
{
    class Controler
    {
        /// <summary>
        /// Constructeur de Controler
        /// </summary>
        public Controler(){ }

        private Vue vue;
        private Modele modele;

        /* Setter - Mise en place des objets*/
        public void ActivateModele(Modele modele) { this.modele = modele; }
        public void ActivateVue (Vue vue) { this.vue = vue; }

        /*  Méthodes */
        public void timerIncrement()
        {
            vue.setPbRemainingValue(modele.updateProgress(true, vue.getPbRemainingValue()));
        }

        public void buttonPlusClicked()
        {
            vue.setPbRemainingValue(modele.updateProgress(true, vue.getPbRemainingValue()));
        }

        public void buttonMinusClicked()
        {
            vue.setPbRemainingValue(modele.updateProgress(false, vue.getPbRemainingValue()));
        }
    }
}
