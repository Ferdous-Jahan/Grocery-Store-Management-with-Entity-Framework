namespace OnlineShopManagementProject
{
    partial class addEmployee
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
            this.signUpContactTextbox = new System.Windows.Forms.TextBox();
            this.signUpContact = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.signUpConfPassTextbox = new System.Windows.Forms.TextBox();
            this.signUpPassTextbox = new System.Windows.Forms.TextBox();
            this.signUpUsernameTextbox = new System.Windows.Forms.TextBox();
            this.signUpConfPass = new System.Windows.Forms.Label();
            this.signUpPass = new System.Windows.Forms.Label();
            this.signUpUserID = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.salaryShow = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.Label();
            this.roleShow = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.roleShow);
            this.panel1.Controls.Add(this.role);
            this.panel1.Controls.Add(this.salaryShow);
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.signUpContactTextbox);
            this.panel1.Controls.Add(this.signUpContact);
            this.panel1.Controls.Add(this.signUpBtn);
            this.panel1.Controls.Add(this.signUpConfPassTextbox);
            this.panel1.Controls.Add(this.signUpPassTextbox);
            this.panel1.Controls.Add(this.signUpUsernameTextbox);
            this.panel1.Controls.Add(this.signUpConfPass);
            this.panel1.Controls.Add(this.signUpPass);
            this.panel1.Controls.Add(this.signUpUserID);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 532);
            this.panel1.TabIndex = 0;
            // 
            // signUpContactTextbox
            // 
            this.signUpContactTextbox.Location = new System.Drawing.Point(403, 219);
            this.signUpContactTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpContactTextbox.Name = "signUpContactTextbox";
            this.signUpContactTextbox.Size = new System.Drawing.Size(216, 26);
            this.signUpContactTextbox.TabIndex = 25;
            // 
            // signUpContact
            // 
            this.signUpContact.AutoSize = true;
            this.signUpContact.Location = new System.Drawing.Point(256, 219);
            this.signUpContact.Name = "signUpContact";
            this.signUpContact.Size = new System.Drawing.Size(65, 20);
            this.signUpContact.TabIndex = 24;
            this.signUpContact.Text = "Contact";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(514, 376);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(105, 59);
            this.signUpBtn.TabIndex = 19;
            this.signUpBtn.Text = "Create Account";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // signUpConfPassTextbox
            // 
            this.signUpConfPassTextbox.Location = new System.Drawing.Point(403, 182);
            this.signUpConfPassTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpConfPassTextbox.Name = "signUpConfPassTextbox";
            this.signUpConfPassTextbox.Size = new System.Drawing.Size(216, 26);
            this.signUpConfPassTextbox.TabIndex = 18;
            // 
            // signUpPassTextbox
            // 
            this.signUpPassTextbox.Location = new System.Drawing.Point(403, 146);
            this.signUpPassTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpPassTextbox.Name = "signUpPassTextbox";
            this.signUpPassTextbox.Size = new System.Drawing.Size(216, 26);
            this.signUpPassTextbox.TabIndex = 17;
            // 
            // signUpUsernameTextbox
            // 
            this.signUpUsernameTextbox.Location = new System.Drawing.Point(403, 111);
            this.signUpUsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpUsernameTextbox.Name = "signUpUsernameTextbox";
            this.signUpUsernameTextbox.Size = new System.Drawing.Size(216, 26);
            this.signUpUsernameTextbox.TabIndex = 16;
            // 
            // signUpConfPass
            // 
            this.signUpConfPass.AutoSize = true;
            this.signUpConfPass.Location = new System.Drawing.Point(256, 186);
            this.signUpConfPass.Name = "signUpConfPass";
            this.signUpConfPass.Size = new System.Drawing.Size(137, 20);
            this.signUpConfPass.TabIndex = 15;
            this.signUpConfPass.Text = "Confirm Password";
            // 
            // signUpPass
            // 
            this.signUpPass.AutoSize = true;
            this.signUpPass.Location = new System.Drawing.Point(256, 150);
            this.signUpPass.Name = "signUpPass";
            this.signUpPass.Size = new System.Drawing.Size(78, 20);
            this.signUpPass.TabIndex = 14;
            this.signUpPass.Text = "Password";
            // 
            // signUpUserID
            // 
            this.signUpUserID.AutoSize = true;
            this.signUpUserID.Location = new System.Drawing.Point(256, 115);
            this.signUpUserID.Name = "signUpUserID";
            this.signUpUserID.Size = new System.Drawing.Size(89, 20);
            this.signUpUserID.TabIndex = 13;
            this.signUpUserID.Text = "User Name";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(256, 253);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(53, 20);
            this.salary.TabIndex = 26;
            this.salary.Text = "Salary";
            // 
            // salaryShow
            // 
            this.salaryShow.Location = new System.Drawing.Point(403, 253);
            this.salaryShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaryShow.Name = "salaryShow";
            this.salaryShow.Size = new System.Drawing.Size(216, 26);
            this.salaryShow.TabIndex = 27;
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Location = new System.Drawing.Point(256, 288);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(42, 20);
            this.role.TabIndex = 28;
            this.role.Text = "Role";
            // 
            // roleShow
            // 
            this.roleShow.Location = new System.Drawing.Point(403, 288);
            this.roleShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roleShow.Name = "roleShow";
            this.roleShow.Size = new System.Drawing.Size(216, 26);
            this.roleShow.TabIndex = 29;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(403, 376);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(105, 59);
            this.cancel.TabIndex = 30;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addEmployee";
            this.Text = "addEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addEmpClose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox signUpContactTextbox;
        private System.Windows.Forms.Label signUpContact;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.TextBox signUpConfPassTextbox;
        private System.Windows.Forms.TextBox signUpPassTextbox;
        private System.Windows.Forms.TextBox signUpUsernameTextbox;
        private System.Windows.Forms.Label signUpConfPass;
        private System.Windows.Forms.Label signUpPass;
        private System.Windows.Forms.Label signUpUserID;
        private System.Windows.Forms.TextBox salaryShow;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.TextBox roleShow;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.Button cancel;
    }
}