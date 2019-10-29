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
    public partial class cHome : Form
    {
        private index LoginPage { get; set; }
        public string newUserId;

        public cHome(index loginpage, string newUserId)
        {
            InitializeComponent();
            this.LoginPage = loginpage;
            this.newUserId = newUserId;
            nameDispaly.Text = newUserId;
        }

        private void cstLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void custClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.LoginPage.Visible = true;
        }

        private void cUpdateInfoBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            updateInfo ui = new updateInfo(this, newUserId);
            ui.Visible = true;
        }

        private void cShopBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            buyItem bi = new buyItem(this);
            bi.Visible = true;
        }
    }
}
