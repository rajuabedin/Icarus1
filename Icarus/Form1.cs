using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icarus
{
    public partial class Dashboard : Form
    {
        static Boolean logedIn = false;
        static Boolean declinedLogin = false;
        

        public Dashboard()
        {
            InitializeComponent();
            while (logedIn == false && declinedLogin != true)
            {
                Form loginForm = new login();
                loginForm.ShowDialog();
            }
            if (declinedLogin == true)
            {
                Close();
            }
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            
            differenceText.Text = (Int32.Parse(predictedText.Text) - Int32.Parse(salesText.Text)).ToString();



        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static void setDeclinedLogin(Boolean value)
        {
            declinedLogin = value;
        }
        public static void setLogin(Boolean value)
        {
            logedIn = value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuProgressBar1.Value != 100)
            {
                bunifuProgressBar1.Value++;
            }
            else
            {
                timer1.Stop();
            }
            
        }

        private void showGraphB_Click(object sender, EventArgs e)
        {
            graph graph = new graph();
            graph.Show();
        }

        private void satrtAnalisyB_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopAnalisyB_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuProgressBar1.Value = 0;
        }
    }
}
