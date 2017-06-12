using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Globalization;


namespace evaluationInternationalisation
{
    public partial class Form1 : Form
    {
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

        private void changeLanguage(string language)
        {
            //Création des objets 
            CultureInfo ciObject = new CultureInfo(language);
            Assembly asObject = Assembly.Load("evaluationInternationalisation");
            ResourceManager rmObject = new ResourceManager("evaluationInternationalisation.language.languageRes", asObject);

            /* Modification des valeurs */

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

        }
    }
}
