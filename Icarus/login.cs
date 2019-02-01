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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string password = passwordText.Text;

            if (username == "kremisisupremo" && password == "saju")
            {
                DialogResult resault = MessageBox.Show("Welcome back " + username);

                if (resault == DialogResult.OK)
                {
                    Dashboard.setLogin(true);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password!!!","Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult resault = MessageBox.Show("Are you sure to exit the application?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resault == DialogResult.Yes)
            {
                Dashboard.setDeclinedLogin(true);
                Close();
            }
        }
        
    }
}
