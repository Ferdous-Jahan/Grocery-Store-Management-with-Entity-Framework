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
    public partial class EmpListAdmin : Form
    {
        Employee model = new Employee();
        private sHome manHome { get; set; }

        public EmpListAdmin()
        {
            InitializeComponent();
        }

        public EmpListAdmin(sHome manHome)
        {
            InitializeComponent();
            this.manHome = manHome;
        }

        private void EmpList_Load(object sender, EventArgs e)
        {
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Employee> emp = cnn.Employees.ToList();

            empListGrid.DataSource = emp;
            delEmpBtn.Enabled = false;
            updateInfo.Enabled = false;

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            addEmployee ae = new addEmployee(this);
            ae.Visible = true;
        }

        private void empListClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.manHome.Visible = true;
        }

        private void empListGridDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (empListGrid.CurrentRow.Index != -1)
            {
                model.userId = Convert.ToInt32(empListGrid.CurrentRow.Cells["userId"].Value);
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    model = db.Employees.Where(x => x.userId == model.userId).FirstOrDefault();
                    name.Text = model.employeeName;
                    phnNumShow.Text = model.phoneNumber;
                    roleShow.Text = model.role;
                    salaryShow.Text = Convert.ToString(model.salary);
                }

                delEmpBtn.Enabled = true;
                updateInfo.Enabled = true;
            }
        }

        private void updateInfo_Click(object sender, EventArgs e)
        {
            model.userId = Convert.ToInt32(empListGrid.CurrentRow.Cells["userId"].Value);
            using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
            {
                model = db.Employees.Where(x => x.userId == model.userId).FirstOrDefault();
                model.employeeName = name.Text;
                model.phoneNumber = phnNumShow.Text;
                model.role = roleShow.Text;
                model.salary = Convert.ToInt32(salaryShow.Text);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Updated successfully");
            }
        }

        private void delEmpBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "delete data",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (ProjectDatabaseEntities db = new ProjectDatabaseEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Employees.Attach(model);
                    }
                    db.Employees.Remove(model);
                    db.SaveChanges();
                    MessageBox.Show("Removed");
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            phnNumShow.Text = string.Empty;
            roleShow.Text = string.Empty;
            salaryShow.Text = string.Empty;
            ProjectDatabaseEntities cnn = new ProjectDatabaseEntities();
            List<Employee> emp = cnn.Employees.ToList();

            empListGrid.DataSource = emp;
            delEmpBtn.Enabled = false;
            updateInfo.Enabled = false;
        }
    }

}