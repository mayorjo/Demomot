/*
* ETML
* Author : Jonathan Mayor
* Date : 09.06.2017
* Summary : Formulaire traduit en 3 langue (fr-en-de)
*/
using System;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace Exercice1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CultureInfoValue = "";


        //Bouton "Français" cliqué
        private void btFr_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo("fr-CH");
            Assembly asObject = Assembly.Load("Exercice1");
            ResourceManager rmObject = new ResourceManager("Exercice1.language.languageRes", asObject);

            /* Modification des valeurs */

            //Modification du label Titre
            lbTitle.Text = rmObject.GetString("title", ciObject);

            //Modification du label Prénom
            lbFirstname.Text = rmObject.GetString("lbFirstname", ciObject);

            //Modification du label Nom
            lbName.Text = rmObject.GetString("lbName", ciObject);

            //Modification du label de date de naissance
            lbBirthday.Text = rmObject.GetString("lbBirthday", ciObject);

            //Modification de la combobox pour les sexes
            string[] gender = new string[3] { rmObject.GetString("cbGender0", ciObject), rmObject.GetString("cbGender1", ciObject), rmObject.GetString("cbGender2", ciObject) };
            cbGender.Items.Clear();
            cbGender.Items.AddRange(gender);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);

            //Modification de la valeur suivant la langue
            CultureInfoValue = "fr-CH";
        }

        //Bouton "English" cliqué
        private void btEn_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo("en-US");
            Assembly asObject = Assembly.Load("Exercice1");
            ResourceManager rmObject = new ResourceManager("Exercice1.language.languageRes", asObject);

            /* Modification des valeurs */

            //Modification du label Titre
            lbTitle.Text = rmObject.GetString("title", ciObject);

            //Modification du label Prénom
            lbFirstname.Text = rmObject.GetString("lbFirstname", ciObject);

            //Modification du label Nom
            lbName.Text = rmObject.GetString("lbName", ciObject);

            //Modification du label de date de naissance
            lbBirthday.Text = rmObject.GetString("lbBirthday", ciObject);

            //Modification de la combobox pour les sexes
            string[] gender = new string[3] { rmObject.GetString("cbGender0", ciObject), rmObject.GetString("cbGender1", ciObject), rmObject.GetString("cbGender2", ciObject) };
            cbGender.Items.Clear();
            cbGender.Items.AddRange(gender);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);

            //Modification de la valeur suivant la langue
            CultureInfoValue = "en-US";
        }

        //Bouton "Deutsch" cliqué
        private void btDe_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo("de-DE");
            Assembly asObject = Assembly.Load("Exercice1");
            ResourceManager rmObject = new ResourceManager("Exercice1.language.languageRes", asObject);

            /* Modification des valeurs */

            //Modification du label Titre
            lbTitle.Text = rmObject.GetString("title", ciObject);

            //Modification du label Prénom
            lbFirstname.Text = rmObject.GetString("lbFirstname", ciObject);

            //Modification du label Nom
            lbName.Text = rmObject.GetString("lbName", ciObject);

            //Modification du label de date de naissance
            lbBirthday.Text = rmObject.GetString("lbBirthday", ciObject);

            //Modification de la combobox pour les sexes
            string[] gender = new string[3] { rmObject.GetString("cbGender0", ciObject), rmObject.GetString("cbGender1", ciObject), rmObject.GetString("cbGender2", ciObject) };
            cbGender.Items.Clear();
            cbGender.Items.AddRange(gender);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);

            //Modification de la valeur suivant la langue
            CultureInfoValue = "de-DE";
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo(CultureInfoValue);
            Assembly asObject = Assembly.Load("Exercice1");
            ResourceManager rmObject = new ResourceManager("Exercice1.language.languageRes", asObject);

            //Affiche un message à l'utilisateur
            MessageBox.Show(rmObject.GetString("stSentence1", ciObject) + tbFirstname.Text + " " + tbName.Text + "." + rmObject.GetString("stSentence2", ciObject) + " " + tbBirthday.Text + "." + rmObject.GetString("stSentence3", ciObject) + " " + cbGender.Text + "." + rmObject.GetString("stSentence3", ciObject) + " " + tbProfession.Text);
        }
    }
}
