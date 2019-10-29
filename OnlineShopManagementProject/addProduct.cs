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
    public partial class addProduct : Form
    {
        Product prod = new Product();

        private ItemList manHome { get; set; }

        public addProduct()
        {
            InitializeComponent();
        }

        public addProduct(ItemList manHome)
        {
            InitializeComponent();
            this.manHome = manHome;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProjectDatabaseEntities adp = new ProjectDatabaseEntities();

            int maxId = adp.Products.Select(p => p.productId).DefaultIfEmpty(0).Max();
            maxId++;

            prod.productName = nameShow.Text;
            prod.price = Convert.ToInt32(priceShow.Text);
            prod.availableQuantity = Convert.ToInt32(quantityShow.Text);
            prod.productId = maxId;

            adp.Products.Add(prod);
            adp.SaveChanges();

            MessageBox.Show("Product Added");
            nameShow.Text = string.Empty;
            priceShow.Text = string.Empty;
            quantityShow.Text = string.Empty;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.manHome.Visible = true;
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.manHome.Visible = true;
        }
    }
}
