namespace OnlineShopManagementProject
{
    partial class EmpListAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateInfo = new System.Windows.Forms.Button();
            this.salaryShow = new System.Windows.Forms.TextBox();
            this.roleShow = new System.Windows.Forms.TextBox();
            this.phnNumShow = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.Label();
            this.phnNum = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.Label();
            this.delEmpBtn = new System.Windows.Forms.Button();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.empListGrid = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.updateInfo);
            this.panel1.Controls.Add(this.salaryShow);
            this.panel1.Controls.Add(this.roleShow);
            this.panel1.Controls.Add(this.phnNumShow);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.phnNum);
            this.panel1.Controls.Add(this.empName);
            this.panel1.Controls.Add(this.delEmpBtn);
            this.panel1.Controls.Add(this.addEmpBtn);
            this.panel1.Controls.Add(this.empListGrid);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 532);
            this.panel1.TabIndex = 0;
            // 
            // updateInfo
            // 
            this.updateInfo.Location = new System.Drawing.Point(172, 242);
            this.updateInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateInfo.Name = "updateInfo";
            this.updateInfo.Size = new System.Drawing.Size(124, 66);
            this.updateInfo.TabIndex = 11;
            this.updateInfo.Text = "Update Information";
            this.updateInfo.UseVisualStyleBackColor = true;
            this.updateInfo.Click += new System.EventHandler(this.updateInfo_Click);
            // 
            // salaryShow
            // 
            this.salaryShow.Location = new System.Drawing.Point(172, 186);
            this.salaryShow.Name = "salaryShow";
            this.salaryShow.Size = new System.Drawing.Size(254, 26);
            this.salaryShow.TabIndex = 10;
            // 
            // roleShow
            // 
            this.roleShow.Location = new System.Drawing.Point(172, 131);
            this.roleShow.Name = "roleShow";
            this.roleShow.Size = new System.Drawing.Size(254, 26);
            this.roleShow.TabIndex = 9;
            // 
            // phnNumShow
            // 
            this.phnNumShow.Location = new System.Drawing.Point(172, 84);
            this.phnNumShow.Name = "phnNumShow";
            this.phnNumShow.Size = new System.Drawing.Size(254, 26);
            this.phnNumShow.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(254, 26);
            this.name.TabIndex = 7;
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(3, 186);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(61, 20);
            this.salary.TabIndex = 6;
            this.salary.Text = "Salary :";
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(3, 131);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(50, 20);
            this.role.TabIndex = 5;
            this.role.Text = "Role :";
            // 
            // phnNum
            // 
            this.phnNum.AutoSize = true;
            this.phnNum.Location = new System.Drawing.Point(3, 84);
            this.phnNum.Name = "phnNum";
            this.phnNum.Size = new System.Drawing.Size(123, 20);
            this.phnNum.TabIndex = 4;
            this.phnNum.Text = "Phone Number :";
            // 
            // empName
            // 
            this.empName.AutoSize = true;
            this.empName.Location = new System.Drawing.Point(3, 29);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(59, 20);
            this.empName.TabIndex = 3;
            this.empName.Text = "Name :";
            // 
            // delEmpBtn
            // 
            this.delEmpBtn.Location = new System.Drawing.Point(302, 242);
            this.delEmpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delEmpBtn.Name = "delEmpBtn";
            this.delEmpBtn.Size = new System.Drawing.Size(124, 66);
            this.delEmpBtn.TabIndex = 2;
            this.delEmpBtn.Text = "Remove Employee";
            this.delEmpBtn.UseVisualStyleBackColor = true;
            this.delEmpBtn.Click += new System.EventHandler(this.delEmpBtn_Click);
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Location = new System.Drawing.Point(562, 242);
            this.addEmpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(124, 66);
            this.addEmpBtn.TabIndex = 1;
            this.addEmpBtn.Text = "Add Employee";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // empListGrid
            // 
            this.empListGrid.AllowUserToAddRows = false;
            this.empListGrid.AllowUserToDeleteRows = false;
            this.empListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empListGrid.Location = new System.Drawing.Point(3, 316);
            this.empListGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empListGrid.Name = "empListGrid";
            this.empListGrid.ReadOnly = true;
            this.empListGrid.RowTemplate.Height = 24;
            this.empListGrid.Size = new System.Drawing.Size(866, 213);
            this.empListGrid.TabIndex = 0;
            this.empListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empListGridDoubleClick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(432, 242);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(124, 66);
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // EmpListAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmpListAdmin";
            this.Text = "EmpList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.empListClose);
            this.Load += new System.EventHandler(this.EmpList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView empListGrid;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Button delEmpBtn;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Label phnNum;
        private System.Windows.Forms.Label empName;
        private System.Windows.Forms.TextBox salaryShow;
        private System.Windows.Forms.TextBox roleShow;
        private System.Windows.Forms.TextBox phnNumShow;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button updateInfo;
        private System.Windows.Forms.Button refreshBtn;
    }
}