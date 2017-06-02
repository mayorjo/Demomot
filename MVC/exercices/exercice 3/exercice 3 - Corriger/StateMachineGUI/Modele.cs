using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineGUI
{
    class Modele
    {
        //Variable
        bool updateProgressVariable = false;
        Modele modele;

        public Modele(Controler controler)
        {
            controler.ActivateModele(modele);
        }

        public int updateProgress(bool up, int pbRemainingValue)
        {
            if (up && pbRemainingValue < 100)
            {
                pbRemainingValue++;
            }
            else if (!up && pbRemainingValue > 0)
            {
                pbRemainingValue--;
            }

            return pbRemainingValue;
        }

        public bool getUpdateProgressVariable()
        {
            return updateProgressVariable;
        }

        public void setUpdateProgressVariable(bool variable)
        {
            updateProgressVariable = variable;
        }



    }
}
