namespace OnlineShopManagementProject
{
    partial class cHome
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
            this.cUpdateInfoBtn = new System.Windows.Forms.Button();
            this.cShopBtn = new System.Windows.Forms.Button();
            this.cstLogOut = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDispaly = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nameDispaly);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cUpdateInfoBtn);
            this.panel1.Controls.Add(this.cShopBtn);
            this.panel1.Controls.Add(this.cstLogOut);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 532);
            this.panel1.TabIndex = 0;
            // 
            // cUpdateInfoBtn
            // 
            this.cUpdateInfoBtn.Location = new System.Drawing.Point(316, 290);
            this.cUpdateInfoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cUpdateInfoBtn.Name = "cUpdateInfoBtn";
            this.cUpdateInfoBtn.Size = new System.Drawing.Size(100, 56);
            this.cUpdateInfoBtn.TabIndex = 3;
            this.cUpdateInfoBtn.Text = "Update Information";
            this.cUpdateInfoBtn.UseVisualStyleBackColor = true;
            this.cUpdateInfoBtn.Click += new System.EventHandler(this.cUpdateInfoBtn_Click);
            // 
            // cShopBtn
            // 
            this.cShopBtn.Location = new System.Drawing.Point(181, 290);
            this.cShopBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cShopBtn.Name = "cShopBtn";
            this.cShopBtn.Size = new System.Drawing.Size(100, 56);
            this.cShopBtn.TabIndex = 2;
            this.cShopBtn.Text = "Shop";
            this.cShopBtn.UseVisualStyleBackColor = true;
            this.cShopBtn.Click += new System.EventHandler(this.cShopBtn_Click);
            // 
            // cstLogOut
            // 
            this.cstLogOut.AutoSize = true;
            this.cstLogOut.Location = new System.Drawing.Point(802, 42);
            this.cstLogOut.Name = "cstLogOut";
            this.cstLogOut.Size = new System.Drawing.Size(66, 20);
            this.cstLogOut.TabIndex = 1;
            this.cstLogOut.TabStop = true;
            this.cstLogOut.Text = "Log Out";
            this.cstLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cstLogOut_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME,";
            // 
            // nameDispaly
            // 
            this.nameDispaly.AutoSize = true;
            this.nameDispaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDispaly.Location = new System.Drawing.Point(278, 171);
            this.nameDispaly.Name = "nameDispaly";
            this.nameDispaly.Size = new System.Drawing.Size(85, 29);
            this.nameDispaly.TabIndex = 5;
            this.nameDispaly.Text = "label2";
            // 
            // cHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.custClose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel cstLogOut;
        private System.Windows.Forms.Button cUpdateInfoBtn;
        private System.Windows.Forms.Button cShopBtn;
        private System.Windows.Forms.Label nameDispaly;
        private System.Windows.Forms.Label label1;
    }
}