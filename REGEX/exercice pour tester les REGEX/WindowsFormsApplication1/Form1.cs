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

              

        private void button1_Click(object sender, EventArgs e)
        {

            //Regex
            Regex regexTest = new Regex(textBox1.Text);

            //Vérification si la valeur match avec la valeur 
            bool regexMatch = regexTest.IsMatch(textBox2.Text);

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
