using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopManagementProject
{
    public partial class signUp : Form
    {
        public static int loginID = 1;
        public static int custID = 1;

        Customer cust = new Customer();
        Login logn = new Login();

        private index LoginPage { get; set; }

        public signUp()
        {
            InitializeComponent();
        }

        public signUp(index loginpage)
        {
            InitializeComponent();
            this.LoginPage = loginpage;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (signUpPassTextbox.Text == signUpConfPassTextbox.Text)
            {
                ProjectDatabaseEntities suo = new ProjectDatabaseEntities();

                int maxId = suo.Customers.Select(p => p.userId).DefaultIfEmpty(0).Max();
                maxId++;

                cust.customerName = signUpUsernameTextbox.Text;
                cust.phoneNumber = signUpContactTextbox.Text;
                cust.address = signUpAdd1.Text;
                cust.userId = maxId;

                suo.Customers.Add(cust);
                suo.SaveChanges();

                int maxIdlog = suo.Logins.Select(p => p.id).DefaultIfEmpty(0).Max();
                maxIdlog++;

                logn.userId = signUpUsernameTextbox.Text;
                logn.password = signUpPassTextbox.Text;
                logn.status = 0;
                logn.id = maxIdlog;

                suo.Logins.Add(logn);
                suo.SaveChanges();

                MessageBox.Show("Account Created");
                this.Visible = false;
                this.LoginPage.Visible = true;
            }

            else
            {
                MessageBox.Show("Password doesn't match");
            }
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void signupclosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }
    }
}
