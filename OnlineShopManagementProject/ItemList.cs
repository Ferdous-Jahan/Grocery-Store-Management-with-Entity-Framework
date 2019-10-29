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
    public partial class ItemList : Form
    {
        Product model = new Product();
        private sHome manHome { get; set; }
        private eHome empHome { get; set; }
        public static int formCheck;

        public ItemList()
        {
            InitializeComponent();
        }

        public ItemList(sHome manHome)
        {
            InitializeComponent();
            this.manHome = manHome;
            formCheck = 2;
        }

        public ItemList(eHome empHome)
        {
            InitializeComponent();
            this.empHome = empHome;
            formCheck = 1;
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Product> pro = cnn.Products.ToList();

            itemGridView.DataSource = pro;
            updateBtn.Enabled = false;
            removeBtn.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            if (formCheck == 2)
                this.manHome.Visible = true;
            else
                this.empHome.Visible = true;
        }

        private void itemGridClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemDoubleClick(object sender, EventArgs e)
        {
            if (itemGridView.CurrentRow.Index != -1)
            {
                model.productId = Convert.ToInt32(itemGridView.CurrentRow.Cells["productId"].Value);
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    model = db.Products.Where(x => x.productId == model.productId).FirstOrDefault();
                    productNameShow.Text = model.productName;
                    priceShow.Text = Convert.ToString(model.price);
                    quantityShow.Text = Convert.ToString(model.availableQuantity);
                }
            }
            updateBtn.Enabled = true;
            removeBtn.Enabled = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            model.productId = Convert.ToInt32(itemGridView.CurrentRow.Cells["productId"].Value);
            using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
            {
                model = db.Products.Where(x => x.productId == model.productId).FirstOrDefault();
                model.productName = productNameShow.Text;
                model.price = Convert.ToInt32(priceShow.Text);
                model.availableQuantity = Convert.ToInt32(quantityShow.Text);

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Products.Attach(model);
                    }
                    db.Products.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Removed");
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {

            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Product> pro = cnn.Products.ToList();

            itemGridView.DataSource = pro;
            updateBtn.Enabled = false;
            removeBtn.Enabled = false;

            productNameShow.Text = string.Empty;
            priceShow.Text = string.Empty;
            quantityShow.Text = string.Empty;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            addProduct adp = new addProduct(this);
            adp.Visible = true;
        }
    }
}
