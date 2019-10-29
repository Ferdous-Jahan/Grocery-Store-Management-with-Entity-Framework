namespace OnlineShopManagementProject
{
    partial class sHome
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
            this.productListBtn = new System.Windows.Forms.Button();
            this.mEmployeeListBtn = new System.Windows.Forms.Button();
            this.mCustomerListBtn = new System.Windows.Forms.Button();
            this.cstLogOut = new System.Windows.Forms.LinkLabel();
            this.username = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameDisplay);
            this.panel1.Controls.Add(this.productListBtn);
            this.panel1.Controls.Add(this.mEmployeeListBtn);
            this.panel1.Controls.Add(this.mCustomerListBtn);
            this.panel1.Controls.Add(this.cstLogOut);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 532);
            this.panel1.TabIndex = 0;
            // 
            // productListBtn
            // 
            this.productListBtn.Location = new System.Drawing.Point(443, 331);
            this.productListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productListBtn.Name = "productListBtn";
            this.productListBtn.Size = new System.Drawing.Size(124, 66);
            this.productListBtn.TabIndex = 6;
            this.productListBtn.Text = "Product List";
            this.productListBtn.UseVisualStyleBackColor = true;
            this.productListBtn.Click += new System.EventHandler(this.mItemListBtn_Click);
            // 
            // mEmployeeListBtn
            // 
            this.mEmployeeListBtn.Location = new System.Drawing.Point(313, 331);
            this.mEmployeeListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mEmployeeListBtn.Name = "mEmployeeListBtn";
            this.mEmployeeListBtn.Size = new System.Drawing.Size(124, 66);
            this.mEmployeeListBtn.TabIndex = 5;
            this.mEmployeeListBtn.Text = "Employee LIst";
            this.mEmployeeListBtn.UseVisualStyleBackColor = true;
            this.mEmployeeListBtn.Click += new System.EventHandler(this.mEmployeeListBtn_Click);
            // 
            // mCustomerListBtn
            // 
            this.mCustomerListBtn.Location = new System.Drawing.Point(182, 331);
            this.mCustomerListBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mCustomerListBtn.Name = "mCustomerListBtn";
            this.mCustomerListBtn.Size = new System.Drawing.Size(124, 66);
            this.mCustomerListBtn.TabIndex = 4;
            this.mCustomerListBtn.Text = "Customer List";
            this.mCustomerListBtn.UseVisualStyleBackColor = true;
            this.mCustomerListBtn.Click += new System.EventHandler(this.mCustomerListBtn_Click);
            // 
            // cstLogOut
            // 
            this.cstLogOut.AutoSize = true;
            this.cstLogOut.Location = new System.Drawing.Point(803, 42);
            this.cstLogOut.Name = "cstLogOut";
            this.cstLogOut.Size = new System.Drawing.Size(66, 20);
            this.cstLogOut.TabIndex = 3;
            this.cstLogOut.TabStop = true;
            this.cstLogOut.Text = "Log Out";
            this.cstLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cstLogOut_LinkClicked);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(177, 178);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 26);
            this.username.TabIndex = 2;
            this.username.Text = "WELCOME,";
            // 
            // nameDisplay
            // 
            this.nameDisplay.AutoSize = true;
            this.nameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(308, 178);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(77, 29);
            this.nameDisplay.TabIndex = 7;
            this.nameDisplay.Text = "name";
            // 
            // sHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "sHome";
            this.Text = "sHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sHomeClose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel cstLogOut;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button mEmployeeListBtn;
        private System.Windows.Forms.Button mCustomerListBtn;
        private System.Windows.Forms.Button productListBtn;
        private System.Windows.Forms.Label nameDisplay;
    }
}