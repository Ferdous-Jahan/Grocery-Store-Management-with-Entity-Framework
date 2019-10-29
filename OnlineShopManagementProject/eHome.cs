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
    public partial class eHome : Form
    {
        private index LoginPage { get; set; }
        private string newUserId;

        public eHome()
        {
            InitializeComponent();
        }

        public eHome(index loginpage, string newUserId)
        {
            InitializeComponent();
            this.LoginPage = loginpage;
            this.newUserId = newUserId;
            nameDisplay.Text = newUserId;
        }

        private void cstLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void empClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void mCustomerListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerList cl = new customerList(this);
            cl.Visible = true;
        }

        private void mItemListBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ItemList il = new ItemList(this);
            il.Visible = true;
        }
    }
}
