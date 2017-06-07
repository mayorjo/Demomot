/*
* ETML
* Auteur : André Gomes
* Modification : Jonathan Mayor
* Date : 07.06.2017
* Summary : Vue - Programme qui permet d'incémenter une progressBar (pb) via des bouttons  
*/

//Using des différents
using System;
using System.Windows.Forms;

namespace StateMachineGUI
{
    public partial class View : Form
    {
        //Variables Objets
        Controler controler;
        Modele modele;

        /// <summary>
        /// Constructeur de l'objet Vue 
        /// </summary>
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

        /// <summary>
        /// Méthode qui incrémente la valeur de la Pb lorsqu'un tick est passé 
        /// </summary>
        /// <param name="sender">Base</param>
        /// <param name="e">Base</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Met les valeurs dont on a besoin dans le modèle
            modele.setValuePbRemaining(pbRemaining.Value);
            modele.setvalueLbProgress(LbprogressValue.Text);

            //Affiche la nouvelle valeur de la pb 
            pbRemaining.Value = controler.updatePbRemaining(true, modele.getValuePbRemaining());

            //Affiche la nouvelle valeur du label
            LbprogressValue.Text = controler.updateLbProgress(modele.getValuePbRemaining());
        }

        /// <summary>
        /// Méthode qui incrémente la valeur de la Pb lorsqu'on clique sur le bouton plus
        /// </summary>
        /// <param name="sender">Base</param>
        /// <param name="e">Base</param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Met les valeurs dont on a besoin dans le modèle
            modele.setValuePbRemaining(pbRemaining.Value);
            modele.setvalueLbProgress(LbprogressValue.Text);

            //Affiche la nouvelle valeur de la pb 
            pbRemaining.Value = controler.updatePbRemaining(true, modele.getValuePbRemaining());

            //Affiche la nouvelle valeur du label
            LbprogressValue.Text = controler.updateLbProgress(modele.getValuePbRemaining());
        }

        /// <summary>
        /// Méthode qui décrémente la valeur de la Pb lorsqu'on clique sur le bouton moins
        /// </summary>
        /// <param name="sender">Base</param>
        /// <param name="e">Base</param>
        private void btnMoins_Click(object sender, EventArgs e)
        {
            //Met les valeurs dont on a besoin dans le modèle
            modele.setValuePbRemaining(pbRemaining.Value);
            modele.setvalueLbProgress(LbprogressValue.Text);

            //Affiche la nouvelle valeur de la pb 
            pbRemaining.Value = controler.updatePbRemaining(false, modele.getValuePbRemaining());

            //Affiche la nouvelle valeur du label
            LbprogressValue.Text = controler.updateLbProgress(modele.getValuePbRemaining());
        }

        /// <summary>
        /// Méthode qui permet de modifier la valeur State
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timState_Tick(object sender, EventArgs e)
        {
            //Update de la valeur ValuePbRemaining avant utilisation 
            modele.setValuePbRemaining(pbRemaining.Value);

            //Update de la valeur de State
            state.Value = controler.updateState(modele.getValuePbRemaining());
        }
    }
}
