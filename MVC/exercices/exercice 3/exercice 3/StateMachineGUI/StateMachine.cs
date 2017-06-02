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
    public partial class StateMachine : Form
    {
        public StateMachine()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateProgress(true);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            updateProgress(true);
        }

        private void updateProgress(bool up)
        {
            if (up && pbRemaining.Value < 100)
            {
                pbRemaining.Value++;
            }
            else if (!up && pbRemaining.Value > 0)
            {
                pbRemaining.Value--;
            }
            progressValue.Text = pbRemaining.Value + "%";
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            updateProgress(false);
        }

        private void timState_Tick(object sender, EventArgs e)
        {
            state.Value = pbRemaining.Value / 5;
        }
    }
}
