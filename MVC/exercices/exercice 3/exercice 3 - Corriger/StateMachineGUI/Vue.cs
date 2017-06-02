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
    public partial class Vue : Form
    {
        //Variables
        Vue vue;

        public Vue (Controler controler)
        {
            controler.ActivateVue(vue);
            InitializeComponent();
        }

        //
        Controler controler = new Controler();

        private void timer1_Tick(object sender, EventArgs e)
        {
            controler.timerIncrement();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            controler.buttonPlusClicked();
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            controler.buttonMinusClicked();
        }

        private void timState_Tick(object sender, EventArgs e)
        {
            state.Value = pbRemaining.Value / 5;
        }

        /*GETTER SETTER*/

        /// <summary>
        /// Permet d'avoir la valeur de PbRemaining
        /// </summary>
        /// <returns>la valeur de PbRemaining</returns>
        public int getPbRemainingValue()
        {
            return pbRemaining.Value;
        }

        /// <summary>
        /// Permet de mettre en place un valeur à PbRemaining
        /// </summary>
        /// <param name="value">valeur à donner</param>
        public void setPbRemainingValue(int value)
        {
            pbRemaining.Value = value;
        }

        /// <summary>
        /// Permet d'avoir la valeur de ProgressValue
        /// </summary>
        /// <returns>la valeur de ProgressValue</returns>
        public string getProgressValue ()
        {
            return progressValue.Text;
        }


        /// <summary>
        /// Permet de mettre en place une valeur à ProgressValue
        /// </summary>
        /// <param name="value">la valeur à mettre en place</param>
        public void setProgressValue (string value)
        {
            progressValue.Text = value;
        }

    }
}
