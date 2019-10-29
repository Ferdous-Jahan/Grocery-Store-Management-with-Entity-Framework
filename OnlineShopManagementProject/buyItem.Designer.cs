namespace OnlineShopManagementProject
{
    partial class buyItem
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
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.buy = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.nameShow = new System.Windows.Forms.TextBox();
            this.priceShow = new System.Windows.Forms.TextBox();
            this.quantityShow = new System.Windows.Forms.TextBox();
            this.selectQuantityShow = new System.Windows.Forms.TextBox();
            this.selectQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.AllowUserToDeleteRows = false;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Location = new System.Drawing.Point(12, 214);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.ReadOnly = true;
            this.itemGridView.RowTemplate.Height = 28;
            this.itemGridView.Size = new System.Drawing.Size(776, 224);
            this.itemGridView.TabIndex = 0;
            this.itemGridView.DoubleClick += new System.EventHandler(this.itemClicked);
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(266, 142);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(108, 35);
            this.buy.TabIndex = 1;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(161, 142);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(99, 35);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(13, 13);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(110, 20);
            this.name.TabIndex = 3;
            this.name.Text = "Product Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(13, 59);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 20);
            this.price.TabIndex = 4;
            this.price.Text = "Price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(13, 99);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(135, 20);
            this.quantity.TabIndex = 5;
            this.quantity.Text = "Available Quantity";
            // 
            // nameShow
            // 
            this.nameShow.Location = new System.Drawing.Point(161, 13);
            this.nameShow.Name = "nameShow";
            this.nameShow.Size = new System.Drawing.Size(213, 26);
            this.nameShow.TabIndex = 6;
            // 
            // priceShow
            // 
            this.priceShow.Location = new System.Drawing.Point(161, 59);
            this.priceShow.Name = "priceShow";
            this.priceShow.Size = new System.Drawing.Size(213, 26);
            this.priceShow.TabIndex = 7;
            // 
            // quantityShow
            // 
            this.quantityShow.Location = new System.Drawing.Point(161, 99);
            this.quantityShow.Name = "quantityShow";
            this.quantityShow.Size = new System.Drawing.Size(213, 26);
            this.quantityShow.TabIndex = 8;
            // 
            // selectQuantityShow
            // 
            this.selectQuantityShow.Location = new System.Drawing.Point(571, 16);
            this.selectQuantityShow.Name = "selectQuantityShow";
            this.selectQuantityShow.Size = new System.Drawing.Size(100, 26);
            this.selectQuantityShow.TabIndex = 9;
            this.selectQuantityShow.Text = "1";
            // 
            // selectQuantity
            // 
            this.selectQuantity.AutoSize = true;
            this.selectQuantity.Location = new System.Drawing.Point(437, 19);
            this.selectQuantity.Name = "selectQuantity";
            this.selectQuantity.Size = new System.Drawing.Size(117, 20);
            this.selectQuantity.TabIndex = 10;
            this.selectQuantity.Text = "Select Quantity";
            // 
            // buyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectQuantity);
            this.Controls.Add(this.selectQuantityShow);
            this.Controls.Add(this.quantityShow);
            this.Controls.Add(this.priceShow);
            this.Controls.Add(this.nameShow);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.price);
            this.Controls.Add(this.name);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.itemGridView);
            this.Name = "buyItem";
            this.Text = "buyItem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed);
            this.Load += new System.EventHandler(this.buyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.TextBox nameShow;
        private System.Windows.Forms.TextBox priceShow;
        private System.Windows.Forms.TextBox quantityShow;
        private System.Windows.Forms.TextBox selectQuantityShow;
        private System.Windows.Forms.Label selectQuantity;
    }
}