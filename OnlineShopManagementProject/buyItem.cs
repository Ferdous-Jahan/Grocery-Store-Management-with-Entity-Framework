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
    public partial class buyItem : Form
    {
        cHome ch { get; set; }
        Product model = new Product();

        public buyItem()
        {
            InitializeComponent();
        }

        public buyItem(cHome ch)
        {
            InitializeComponent();
            this.ch = ch;
        }

        private void buyItem_Load(object sender, EventArgs e)
        {
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Product> pro = cnn.Products.ToList();

            itemGridView.DataSource = pro;
            buy.Enabled = false;
            selectQuantityShow.Enabled = false;
        }

        private void itemClicked(object sender, EventArgs e)
        {
            if (itemGridView.CurrentRow.Index != -1)
            {
                model.productId = Convert.ToInt32(itemGridView.CurrentRow.Cells["productId"].Value);
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    model = db.Products.Where(x => x.productId == model.productId).FirstOrDefault();
                    nameShow.Text = model.productName;
                    priceShow.Text = Convert.ToString(model.price);
                    quantityShow.Text = Convert.ToString(model.availableQuantity);
                }
            }
            buy.Enabled = true;
            selectQuantityShow.Enabled = true;
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            ch.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ch.Visible = true;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(selectQuantityShow.Text) < Convert.ToInt32(quantityShow.Text))
            {
                model.productId = Convert.ToInt32(itemGridView.CurrentRow.Cells["productId"].Value);
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    model = db.Products.Where(x => x.productId == model.productId).FirstOrDefault();
                    model.availableQuantity = Convert.ToInt32(Convert.ToInt32(quantityShow.Text) - Convert.ToInt32(selectQuantityShow.Text));
                    model.productName = nameShow.Text;
                    model.price = Convert.ToInt32(priceShow.Text);

                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Successfully Bought");

                    ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
                    List<Product> pro = cnn.Products.ToList();

                    itemGridView.DataSource = pro;
                    buy.Enabled = false;
                    selectQuantityShow.Enabled = false;
                    selectQuantityShow.Text = "1";
                    nameShow.Text = string.Empty;
                    priceShow.Text = string.Empty;
                    quantityShow.Text = string.Empty;
                }
            }

            else
            {
                MessageBox.Show("Quantity is not available");
                ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
                List<Product> pro = cnn.Products.ToList();

                itemGridView.DataSource = pro;
                buy.Enabled = false;
                selectQuantityShow.Enabled = false;
                selectQuantityShow.Text = "1";
                nameShow.Text = string.Empty;
                priceShow.Text = string.Empty;
                quantityShow.Text = string.Empty;
            }
        }
    }
}
