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
    public partial class customerList : Form
    {
        sHome manHome{ get; set; }
        eHome empHome { get; set; }
        public static int formCheck;

        public customerList()
        {
            InitializeComponent();
        }

        public customerList(sHome manHome)
        {
            InitializeComponent();
            this.manHome = manHome;
            formCheck = 2;
        }

        public customerList(eHome empHome)
        {
            InitializeComponent();
            this.empHome = empHome;
            formCheck = 1;
        }

        private void customerList_Load(object sender, EventArgs e)
        {
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Customer> cst = cnn.Customers.ToList();

            custGridView.DataSource = cst;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if(formCheck == 2)
            this.manHome.Visible = true;
            else
            this.empHome.Visible = true;
        }
    }
}
