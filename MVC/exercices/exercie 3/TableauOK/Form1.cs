using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableauOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int LABEL_SIZE = 20;

        private void btnOK_Click(object sender, EventArgs e)
        {
            int rows, columns;

            if (txtRow.Text == "" || !int.TryParse(txtRow.Text, out rows) || rows <= 0)
            {
                MessageBox.Show("Le nombre de lignes est invalide.", "Erreur !");
                txtRow.Focus();
                txtRow.SelectAll();
                return;
            }
            if (txtColumn.Text == "" || !int.TryParse(txtColumn.Text, out columns) || columns <= 0)
            {
                MessageBox.Show("Le nombre de colonnes est invalide.", "Erreur !");
                txtColumn.Focus();
                txtColumn.SelectAll();
                return;
            }

            pnlTable.Controls.Clear();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Label label = new Label();
                        label.Location = new Point(LABEL_SIZE * j + 4, LABEL_SIZE * i + 4);
                        label.Size = new Size(LABEL_SIZE, LABEL_SIZE);
                        label.BackColor = Color.Red;

                        pnlTable.Controls.Add(label);
                    }
                }
            }
            pnlTable.Size = new Size(Math.Max(337, columns * LABEL_SIZE + 8), Math.Max(28, rows * LABEL_SIZE + 8));
            // 377 435
            Size = new Size(Math.Max(377, pnlTable.Width + 38), Math.Max(136, pnlTable.Height + 102));

            txtRow.Focus();
            txtRow.SelectAll();
        }

        private void txtRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int rows;
                if (txtRow.Text == "" || !int.TryParse(txtRow.Text, out rows) || rows <= 0)
                {
                    MessageBox.Show("Le nombre de lignes est invalide.", "Erreur !");
                    txtRow.Focus();
                    txtRow.SelectAll();
                }
                else
                {
                    txtColumn.Focus();
                    txtColumn.SelectAll();
                }
            }
        }

        private void txtColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK_Click(sender, e);
            }
        }
    }
}
