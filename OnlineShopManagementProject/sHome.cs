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
    public partial class sHome : Form
    {
        private index LoginPage { get; set; }
        private string newUSerId;

        public sHome()
        {
            InitializeComponent();
        }

        public sHome(index loginpage, string newUSerId)
        {
            InitializeComponent();
            this.LoginPage = loginpage;
            this.newUSerId = newUSerId;
            nameDisplay.Text = newUSerId;
        }

        private void mCustomerListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerList cl = new customerList(this);
            cl.Visible = true;
        }

        private void mEmployeeListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmpListAdmin showEmp = new EmpListAdmin(this);
            showEmp.Visible = true;
        }

        private void cstLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void sHomeClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void mItemListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ItemList showItem = new ItemList(this);
            showItem.Visible = true;
        }
    }
}
