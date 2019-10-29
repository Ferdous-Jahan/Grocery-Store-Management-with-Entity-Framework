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
    public partial class updateInfo : Form
    {
        cHome cstHome { get; set; }
        private string newUSerId;
        Customer model = new Customer();
        Login logn = new Login();

        public updateInfo()
        {
            InitializeComponent();
        }

        public updateInfo(cHome cstHome,string newUserId)
        {
            InitializeComponent();
            this.cstHome = cstHome;
            this.newUSerId = newUserId;

            using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
            {
                model = db.Customers.Where(x => x.customerName == newUSerId).FirstOrDefault();
                nameShow.Text = model.customerName;
                phnShow.Text = model.phoneNumber;
                addShow.Text = model.address;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
            {
                model = db.Customers.Where(x => x.customerName == newUSerId).FirstOrDefault();

                model.customerName = nameShow.Text;
                model.phoneNumber = phnShow.Text;
                model.address = addShow.Text;

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                logn = db.Logins.Where(x => x.userId == newUSerId).FirstOrDefault();

                logn.userId = nameShow.Text;

                db.Entry(logn).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updated Successfully");

                this.Visible = false;
                cstHome.Visible = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cstHome.Visible = true;
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            cstHome.Visible = true;
        }
    }
}
