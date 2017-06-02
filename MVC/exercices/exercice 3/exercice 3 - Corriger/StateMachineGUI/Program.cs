using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StateMachineGUI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controler controler = new Controler();
            Modele modele = new Modele(controler);
            Vue vue = new Vue(controler);

            Application.Run(vue);


        }
    }
}
