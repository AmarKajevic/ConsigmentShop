namespace ConsigmentShopUi
{
    partial class ConsigmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemsListbox = new System.Windows.Forms.ListBox();
            this.ItemsListBoxlabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListboxlabel = new System.Windows.Forms.Label();
            this.ShoppingCartListbox = new System.Windows.Forms.ListBox();
            this.Makepurchase = new System.Windows.Forms.Button();
            this.VendorListBoxlabel = new System.Windows.Forms.Label();
            this.VendorlistBox = new System.Windows.Forms.ListBox();
            this.storeProfitlabel = new System.Windows.Forms.Label();
            this.StoreProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderText.Location = new System.Drawing.Point(12, 9);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(384, 45);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consigment Shop Demo";
            // 
            // ItemsListbox
            // 
            this.ItemsListbox.FormattingEnabled = true;
            this.ItemsListbox.ItemHeight = 21;
            this.ItemsListbox.Location = new System.Drawing.Point(12, 92);
            this.ItemsListbox.Name = "ItemsListbox";
            this.ItemsListbox.Size = new System.Drawing.Size(279, 172);
            this.ItemsListbox.TabIndex = 1;
            // 
            // ItemsListBoxlabel
            // 
            this.ItemsListBoxlabel.AutoSize = true;
            this.ItemsListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsListBoxlabel.Location = new System.Drawing.Point(12, 68);
            this.ItemsListBoxlabel.Name = "ItemsListBoxlabel";
            this.ItemsListBoxlabel.Size = new System.Drawing.Size(96, 21);
            this.ItemsListBoxlabel.TabIndex = 2;
            this.ItemsListBoxlabel.Text = "Store Items";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(302, 153);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(146, 38);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add to Cart ->";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ShoppingCartListboxlabel
            // 
            this.ShoppingCartListboxlabel.AutoSize = true;
            this.ShoppingCartListboxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShoppingCartListboxlabel.Location = new System.Drawing.Point(454, 68);
            this.ShoppingCartListboxlabel.Name = "ShoppingCartListboxlabel";
            this.ShoppingCartListboxlabel.Size = new System.Drawing.Size(119, 21);
            this.ShoppingCartListboxlabel.TabIndex = 5;
            this.ShoppingCartListboxlabel.Text = "Shopping Cart";
            // 
            // ShoppingCartListbox
            // 
            this.ShoppingCartListbox.FormattingEnabled = true;
            this.ShoppingCartListbox.ItemHeight = 21;
            this.ShoppingCartListbox.Location = new System.Drawing.Point(454, 92);
            this.ShoppingCartListbox.Name = "ShoppingCartListbox";
            this.ShoppingCartListbox.Size = new System.Drawing.Size(279, 172);
            this.ShoppingCartListbox.TabIndex = 4;
            // 
            // Makepurchase
            // 
            this.Makepurchase.Location = new System.Drawing.Point(583, 270);
            this.Makepurchase.Name = "Makepurchase";
            this.Makepurchase.Size = new System.Drawing.Size(150, 39);
            this.Makepurchase.TabIndex = 6;
            this.Makepurchase.Text = "Purchase";
            this.Makepurchase.UseVisualStyleBackColor = true;
            this.Makepurchase.Click += new System.EventHandler(this.Makepurchase_Click);
            // 
            // VendorListBoxlabel
            // 
            this.VendorListBoxlabel.AutoSize = true;
            this.VendorListBoxlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VendorListBoxlabel.Location = new System.Drawing.Point(12, 333);
            this.VendorListBoxlabel.Name = "VendorListBoxlabel";
            this.VendorListBoxlabel.Size = new System.Drawing.Size(72, 21);
            this.VendorListBoxlabel.TabIndex = 8;
            this.VendorListBoxlabel.Text = "Vendors";
            // 
            // VendorlistBox
            // 
            this.VendorlistBox.FormattingEnabled = true;
            this.VendorlistBox.ItemHeight = 21;
            this.VendorlistBox.Location = new System.Drawing.Point(12, 366);
            this.VendorlistBox.Name = "VendorlistBox";
            this.VendorlistBox.Size = new System.Drawing.Size(279, 172);
            this.VendorlistBox.TabIndex = 7;
            // 
            // storeProfitlabel
            // 
            this.storeProfitlabel.AutoSize = true;
            this.storeProfitlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitlabel.Location = new System.Drawing.Point(454, 333);
            this.storeProfitlabel.Name = "storeProfitlabel";
            this.storeProfitlabel.Size = new System.Drawing.Size(101, 21);
            this.storeProfitlabel.TabIndex = 9;
            this.storeProfitlabel.Text = "Store Profit:";
            // 
            // StoreProfitValue
            // 
            this.StoreProfitValue.AutoSize = true;
            this.StoreProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StoreProfitValue.Location = new System.Drawing.Point(578, 333);
            this.StoreProfitValue.Name = "StoreProfitValue";
            this.StoreProfitValue.Size = new System.Drawing.Size(50, 21);
            this.StoreProfitValue.TabIndex = 10;
            this.StoreProfitValue.Text = "$0.00";
            // 
            // ConsigmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 587);
            this.Controls.Add(this.StoreProfitValue);
            this.Controls.Add(this.storeProfitlabel);
            this.Controls.Add(this.VendorListBoxlabel);
            this.Controls.Add(this.VendorlistBox);
            this.Controls.Add(this.Makepurchase);
            this.Controls.Add(this.ShoppingCartListboxlabel);
            this.Controls.Add(this.ShoppingCartListbox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemsListBoxlabel);
            this.Controls.Add(this.ItemsListbox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsigmentShop";
            this.Text = "Consigment Shop Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderText;
        private ListBox ItemsListbox;
        private Label ItemsListBoxlabel;
        private Button AddToCart;
        private Label ShoppingCartListboxlabel;
        private ListBox ShoppingCartListbox;
        private Button Makepurchase;
        private Label VendorListBoxlabel;
        private ListBox VendorlistBox;
        private Label storeProfitlabel;
        private Label StoreProfitValue;
    }
}