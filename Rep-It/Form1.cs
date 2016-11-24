using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rep_It
{
    public partial class Form1 : Form
    {
        //Variables used for perform operation
        int timeLeft = 10;
        int anInteger;
        int secondPause = 1;
        static bool restoreIt = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            //Variables for input type control.
            int n, m, c;
            bool isNumeric = int.TryParse(txtBoxNumExec.Text, out n);
            bool isNumeric2 = int.TryParse(txtBoxTimer.Text, out m);
            bool isNumeric3 = int.TryParse(txtBoxInterval.Text, out c);

            if (isNumeric && isNumeric2 && isNumeric3)
            {
                //Conversion and Parsing of variables.

                anInteger = Convert.ToInt32(txtBoxNumExec.Text);
                anInteger = int.Parse(txtBoxNumExec.Text);

                timeLeft = Convert.ToInt32(txtBoxTimer.Text);
                timeLeft = int.Parse(txtBoxTimer.Text);

                secondPause = Convert.ToInt32(txtBoxInterval.Text);
                secondPause = int.Parse(txtBoxInterval.Text);

                //Start timer.
                timer1.Start();
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                this.lblMessageTimer.Text = "Will be executed " + txtBoxKeyStore.Text + " " + anInteger.ToString() + " starting from " + timeLeft + " seconds";
                timeLeft = timeLeft - 1;
            }
            else
            {
                // If the user ran out of time, stop the timer 
                // and execute operation.
                timer1.Stop();
                this.lblMessageTimer.Text = " ";
                timeLeft = 10;
                for (int i = 0; i < anInteger; i++)
                {
                    SendKeys.Send(txtBoxKeyStore.Text);
                    System.Threading.Thread.Sleep(secondPause * 1000);
                }
            }

        }

        private void btnRestoreKey_Click(object sender, EventArgs e)
        {
            //Restore the 0 the variable for control the input 
            restoreIt = true;
        }

        private void pictureBoxGLogoLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/enryls/Rep-It");
        }
    }
}
