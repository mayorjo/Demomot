using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variable
        Regex regexTest = new Regex("cheval");       

        private void button1_Click(object sender, EventArgs e)
        {
            //Vérification si la valeur match
            bool regexMatch = regexTest.IsMatch(" ");

            if(regexMatch == true)
            {
                panel1.BackColor = Color.Green;
            }

            else
            {
                panel1.BackColor = Color.Red;
            }
            
        }
    }
}
