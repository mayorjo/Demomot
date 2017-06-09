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
            string[] sex = new string[3] { rmObject.GetString("cbSex0", ciObject), rmObject.GetString("cbSex1", ciObject), rmObject.GetString("cbSex2", ciObject) };
            cbSex.Items.Clear();
            cbSex.Items.AddRange(sex);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);
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
            string[] sex = new string[3] { rmObject.GetString("cbSex0", ciObject), rmObject.GetString("cbSex1", ciObject), rmObject.GetString("cbSex2", ciObject) };
            cbSex.Items.Clear();
            cbSex.Items.AddRange(sex);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);
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
            string[] sex = new string[3] { rmObject.GetString("cbSex0", ciObject), rmObject.GetString("cbSex1", ciObject), rmObject.GetString("cbSex2", ciObject) };
            cbSex.Items.Clear();
            cbSex.Items.AddRange(sex);

            //Modification du label profession
            lbprofession.Text = rmObject.GetString("lbProfession", ciObject);

            //Modification du bouton soumettre
            btSubmit.Text = rmObject.GetString("btsubmit", ciObject);
        }
    }
}
