/*
* ETML
* Author : Jonathan Mayor
* Modificator : You
* Date : 09.06.2017
* Summary : Programme qui devra permettre à l'utilisateur d'avoir le programme en plusieurs langue 
*/

/* Objet 
* - labelTitle = label pour le titre 
* - buttonFrench = bouton pour mettre le programme en français
* - buttonEnglish = bouton pour mettre le programme en anglais
* - labelSentence = texte qui sera modifié pour afficher un texte dans la langue demandée
* - textBoxUserAnswer = Interaction avec l'utilisateur 
*/
using System;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace theorie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFrench_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo("fr-CH");
            Assembly asObject = Assembly.Load("theorie");
            ResourceManager rmObject = new ResourceManager("theorie.Language.languageRes", asObject);

            //application des valeurs 
            labelSentence.Text = rmObject.GetString("sentence", ciObject);
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo("en-US");
            Assembly asObject = Assembly.Load("theorie");
            ResourceManager rmObject = new ResourceManager("theorie.Language.languageRes", asObject);

            //application des valeurs 
            labelSentence.Text = rmObject.GetString("sentence", ciObject);
        }

    }
}