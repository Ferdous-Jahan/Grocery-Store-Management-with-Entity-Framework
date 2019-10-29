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
    public partial class addEmployee : Form
    {
        public static int loginID = 1;
        public static int custID = 1;

        Employee emp = new Employee();
        Login logn = new Login();

        private EmpListAdmin empList { get; set; }

        public addEmployee()
        {
            InitializeComponent();
        }

        public addEmployee(EmpListAdmin empList)
        {
            InitializeComponent();
            this.empList = empList;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (signUpPassTextbox.Text == signUpConfPassTextbox.Text)
            {
                ProjectDatabaseEntities addEmp = new ProjectDatabaseEntities();

                int maxId = addEmp.Employees.Select(p => p.userId).DefaultIfEmpty(0).Max();
                maxId++;

                emp.employeeName = signUpUsernameTextbox.Text;
                emp.phoneNumber = signUpContactTextbox.Text;
                emp.role = roleShow.Text;
                emp.salary = Convert.ToInt32(salaryShow.Text);
                emp.userId = maxId;

                addEmp.Employees.Add(emp);
                addEmp.SaveChanges();

                int maxIdlog = addEmp.Logins.Select(p => p.id).DefaultIfEmpty(0).Max();
                maxIdlog++;

                logn.userId = signUpUsernameTextbox.Text;
                logn.password = signUpPassTextbox.Text;
                logn.status = 1;
                logn.id = maxIdlog;

                addEmp.Logins.Add(logn);
                addEmp.SaveChanges();

                MessageBox.Show("Account Created");
                this.Visible = false;
                this.empList.Visible = true;
            }

            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void empRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void admRBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.empList.Visible = true;
        }

        private void addEmpClose(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.empList.Visible = true;
        }
    }
}
