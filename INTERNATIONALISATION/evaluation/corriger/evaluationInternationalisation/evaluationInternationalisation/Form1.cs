//Base
using System;
using System.Windows.Forms;
//using concernant les resources 
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace evaluationInternationalisation
{
    public partial class Form1 : Form
    {

        private string language = "fr-CH";

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeLanguage("fr-CH");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeLanguage("en-US");
        }

        /// <summary>
        /// Méthode qui permet de modifier les labels suivant la langue
        /// </summary>
        /// <param name="language">la langue sous le format : fr-CH, en-US</param>
        private void changeLanguage(string language)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo(language);
            Assembly asObject = Assembly.Load("evaluationInternationalisation");
            ResourceManager rmObject = new ResourceManager("evaluationInternationalisation.language.languageRes", asObject);

            /* Modification des valeurs */

            //Variable language
            this.language = language;

            //Titre 
            lbTitle.Text = rmObject.GetString("strTitle", ciObject);

            //GroupBox
            gbPersonal.Text = rmObject.GetString("grpbox1", ciObject);
            gbPublic.Text = rmObject.GetString("grpbox2", ciObject);
            gbPassword.Text = rmObject.GetString("grpbox3", ciObject);

            //Informations personnelles
            lbName.Text = rmObject.GetString("strName", ciObject);
            lbFirstname.Text = rmObject.GetString("strFirstname", ciObject);
            lbAddress.Text = rmObject.GetString("strAddress", ciObject);
            lbZip.Text = rmObject.GetString("strZip", ciObject);
            lbCity.Text = rmObject.GetString("strCity", ciObject);
            lbCountry.Text = rmObject.GetString("strCountry", ciObject);

            //Informations publiques 
            lbNickname.Text = rmObject.GetString("strNickname", ciObject);
            lbMail.Text = rmObject.GetString("strMail", ciObject);

            //Mot de passe
            lbPassword.Text = rmObject.GetString("strPassword", ciObject);
            lbConfirm.Text = rmObject.GetString("strConfirm", ciObject);

            //Boutons
            btReset.Text = rmObject.GetString("butReset", ciObject);
            btSubmit.Text = rmObject.GetString("butSubmit", ciObject);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Remise à zero de toutes les textboxs
            tbName.Text = "";
            tbFirstname.Text = "";
            tbAddress.Text = "";
            tbZip.Text = "";
            tbCity.Text = "";
            tbCountry.Text = "";
            tbNickname.Text = "";
            tbMail.Text = "";
            tbPassword.Text = "";
            tbConfirm.Text = "";
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo(language);
            Assembly asObject = Assembly.Load("evaluationInternationalisation");
            ResourceManager rmObject = new ResourceManager("evaluationInternationalisation.language.languageRes", asObject);

            //Création de la MesageBox
            MessageBox.Show
                (
                    //Création du message qui sera dans la messagebox
                    rmObject.GetString("emailContent1", ciObject) + " " + tbFirstname.Text + "\n" +
                    rmObject.GetString("emailContent2", ciObject) + "\n" +
                    rmObject.GetString("emailContent3", ciObject) + "\n" +
                    rmObject.GetString("strNickname", ciObject) + " : " + tbNickname.Text + "\n" +
                    rmObject.GetString("strMail", ciObject) + " : " + tbMail.Text + "\n"
                );
        }
    }
}