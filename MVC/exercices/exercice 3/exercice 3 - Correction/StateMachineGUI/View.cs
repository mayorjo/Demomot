using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StateMachineGUI
{
    public partial class View : Form
    {
        //Variables Objet
        Controler controler;
        Modele modele;

        public View()
        {
            InitializeComponent();
            
            //Création des objets
            Controler controler = new Controler();
            Modele modele = new Modele();

            //Assignation des objets
            this.controler = controler;
            this.modele = modele;
        }

        //Création des objet Controleurs et Modele
        


        private void timer1_Tick(object sender, EventArgs e)
        {
            modele.updateProgress(true, pbRemaining.Value);
            modele.updateProgressValue(pbRemaining.Value);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            updateProgress(true);
        }


        private void btnMoins_Click(object sender, EventArgs e)
        {
            updateProgress(false);
        }

        private void timState_Tick(object sender, EventArgs e)
        {
            //state.Value = pbRemaining.Value / 5;
        }
    }
}
