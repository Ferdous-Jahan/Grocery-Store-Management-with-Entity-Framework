namespace OnlineShopManagementProject
{
    partial class ItemList
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.productNameShow = new System.Windows.Forms.TextBox();
            this.priceShow = new System.Windows.Forms.TextBox();
            this.quantityShow = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.removeBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.quantityShow);
            this.panel1.Controls.Add(this.priceShow);
            this.panel1.Controls.Add(this.productNameShow);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.itemGridView);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // itemGridView
            // 
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(3, 264);
            this.itemGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(865, 263);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemGridClick);
            this.itemGridView.DoubleClick += new System.EventHandler(this.itemDoubleClick);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(3, 81);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 20);
            this.price.TabIndex = 2;
            this.price.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(3, 129);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(135, 20);
            this.quantity.TabIndex = 3;
            this.quantity.Text = "Available Quantity";
            // 
            // productNameShow
            // 
            this.productNameShow.Location = new System.Drawing.Point(139, 36);
            this.productNameShow.Name = "productNameShow";
            this.productNameShow.Size = new System.Drawing.Size(255, 26);
            this.productNameShow.TabIndex = 4;
            // 
            // priceShow
            // 
            this.priceShow.Location = new System.Drawing.Point(139, 84);
            this.priceShow.Name = "priceShow";
            this.priceShow.Size = new System.Drawing.Size(255, 26);
            this.priceShow.TabIndex = 5;
            // 
            // quantityShow
            // 
            this.quantityShow.Location = new System.Drawing.Point(139, 132);
            this.quantityShow.Name = "quantityShow";
            this.quantityShow.Size = new System.Drawing.Size(255, 26);
            this.quantityShow.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(139, 188);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(151, 46);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update Info";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(296, 188);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(151, 46);
            this.removeBtn.TabIndex = 8;
            this.removeBtn.Text = "Remove product";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(453, 188);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(151, 46);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(610, 188);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(151, 46);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemList";
            this.Text = "ItemList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.itemClose);
            this.Load += new System.EventHandler(this.ItemList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox quantityShow;
        private System.Windows.Forms.TextBox priceShow;
        private System.Windows.Forms.TextBox productNameShow;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label name;
    }
}