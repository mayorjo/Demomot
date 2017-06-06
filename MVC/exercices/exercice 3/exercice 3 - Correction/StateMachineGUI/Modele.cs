using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineGUI
{
    public class Modele
    {
        //Contructeur de Modèle 
        public Modele() { }

        public int updateProgress(bool up, int variable)
        {
            if (up && variable < 100)
            {
                variable++;
            }
            else if (!up && variable > 0)
            {
                variable--;
            }

            return variable;
        }

        public string updateProgressValue(int variable)
        {
            return variable + "%";
        }
        
    }
}
