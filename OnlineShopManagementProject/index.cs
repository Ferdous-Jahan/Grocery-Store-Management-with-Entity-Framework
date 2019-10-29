using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopManagementProject
{
    public partial class index : Form
    {
        public string newUSerId;
        public index()
        {
            InitializeComponent();
        }

        private void LogInStaffBtn_Click(object sender, EventArgs e)
        {
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Login> emp = cnn.Logins.ToList();

            var data = (from a in emp where (a.userId.Equals(usernameTextbox.Text) && a.password.Equals(passwordTextbox.Text)) select a).FirstOrDefault();

            if(data != null)
            {
                this.Visible = false;
                MessageBox.Show("Valid!");

                if (data.status == 2)
                {
                    newUSerId = usernameTextbox.Text;
                    usernameTextbox.Text = string.Empty;
                    passwordTextbox.Text = string.Empty;
                    sHome home = new sHome(this, newUSerId);
                    home.Visible = true;
                }
                else if (data.status == 1)
                {
                    newUSerId = usernameTextbox.Text;
                    usernameTextbox.Text = string.Empty;
                    passwordTextbox.Text = string.Empty;
                    eHome home = new eHome(this, newUSerId);
                    home.Visible = true;

                }
                else if (data.status == 0)
                {
                    newUSerId = usernameTextbox.Text;
                    usernameTextbox.Text = string.Empty;
                    passwordTextbox.Text = string.Empty;
                    cHome home = new cHome(this, newUSerId);
                    home.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("invalid!");
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            signUp su = new signUp(this);
            su.Visible = true;
        }
    }
}

        

