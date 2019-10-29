namespace OnlineShopManagementProject
{
    partial class addProduct
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
            this.productName = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.nameShow = new System.Windows.Forms.TextBox();
            this.priceShow = new System.Windows.Forms.TextBox();
            this.quantityShow = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(98, 68);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(110, 20);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(98, 116);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 20);
            this.price.TabIndex = 1;
            this.price.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(98, 167);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(135, 20);
            this.quantity.TabIndex = 2;
            this.quantity.Text = "Available Quantity";
            // 
            // nameShow
            // 
            this.nameShow.Location = new System.Drawing.Point(253, 68);
            this.nameShow.Name = "nameShow";
            this.nameShow.Size = new System.Drawing.Size(236, 26);
            this.nameShow.TabIndex = 3;
            // 
            // priceShow
            // 
            this.priceShow.Location = new System.Drawing.Point(253, 116);
            this.priceShow.Name = "priceShow";
            this.priceShow.Size = new System.Drawing.Size(236, 26);
            this.priceShow.TabIndex = 4;
            // 
            // quantityShow
            // 
            this.quantityShow.Location = new System.Drawing.Point(253, 161);
            this.quantityShow.Name = "quantityShow";
            this.quantityShow.Size = new System.Drawing.Size(236, 26);
            this.quantityShow.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(253, 228);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 37);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(359, 228);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(130, 37);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.quantityShow);
            this.Controls.Add(this.priceShow);
            this.Controls.Add(this.nameShow);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productName);
            this.Name = "addProduct";
            this.Text = "addProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox nameShow;
        private System.Windows.Forms.TextBox priceShow;
        private System.Windows.Forms.TextBox quantityShow;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
    }
}