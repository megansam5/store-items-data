namespace ConsignmentShopUI
{
    partial class ConsignmentShopTest
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
            this.makePurchaseButton = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.headerText = new System.Windows.Forms.Label();
            this.label1venderListboxLabel = new System.Windows.Forms.Label();
            this.venderListbox = new System.Windows.Forms.ListBox();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makePurchaseButton
            // 
            this.makePurchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.makePurchaseButton.Location = new System.Drawing.Point(661, 342);
            this.makePurchaseButton.Name = "makePurchaseButton";
            this.makePurchaseButton.Size = new System.Drawing.Size(192, 57);
            this.makePurchaseButton.TabIndex = 13;
            this.makePurchaseButton.Text = "Purchase";
            this.makePurchaseButton.UseVisualStyleBackColor = false;
            this.makePurchaseButton.Click += new System.EventHandler(this.makePurchaseButton_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(575, 110);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(178, 32);
            this.shoppingCartListboxLabel.TabIndex = 12;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 25;
            this.shoppingCartListbox.Location = new System.Drawing.Point(575, 145);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(278, 179);
            this.shoppingCartListbox.TabIndex = 11;
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addToCartButton.Location = new System.Drawing.Point(330, 256);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(192, 57);
            this.addToCartButton.TabIndex = 10;
            this.addToCartButton.Text = "Add To Cart ->";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsListboxLabel.Location = new System.Drawing.Point(6, 110);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(143, 32);
            this.itemsListboxLabel.TabIndex = 9;
            this.itemsListboxLabel.Text = "Store Items";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 25;
            this.itemsListbox.Location = new System.Drawing.Point(6, 145);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(278, 179);
            this.itemsListbox.TabIndex = 8;
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerText.Location = new System.Drawing.Point(6, 12);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(503, 54);
            this.headerText.TabIndex = 7;
            this.headerText.Text = "Consignment Shop Demo";
            // 
            // label1venderListboxLabel
            // 
            this.label1venderListboxLabel.AutoSize = true;
            this.label1venderListboxLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1venderListboxLabel.Location = new System.Drawing.Point(6, 352);
            this.label1venderListboxLabel.Name = "label1venderListboxLabel";
            this.label1venderListboxLabel.Size = new System.Drawing.Size(107, 32);
            this.label1venderListboxLabel.TabIndex = 15;
            this.label1venderListboxLabel.Text = "Vendors";
            // 
            // venderListbox
            // 
            this.venderListbox.FormattingEnabled = true;
            this.venderListbox.ItemHeight = 25;
            this.venderListbox.Location = new System.Drawing.Point(6, 387);
            this.venderListbox.Name = "venderListbox";
            this.venderListbox.Size = new System.Drawing.Size(278, 179);
            this.venderListbox.TabIndex = 14;
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitValue.Location = new System.Drawing.Point(750, 446);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(77, 32);
            this.storeProfitValue.TabIndex = 16;
            this.storeProfitValue.Text = "£0.00";
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeProfitLabel.Location = new System.Drawing.Point(575, 446);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(152, 32);
            this.storeProfitLabel.TabIndex = 17;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // ConsignmentShopTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 583);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.label1venderListboxLabel);
            this.Controls.Add(this.venderListbox);
            this.Controls.Add(this.makePurchaseButton);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Name = "ConsignmentShopTest";
            this.Text = "ConsignmentShopTest";
            this.Load += new System.EventHandler(this.ConsignmentShopTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button makePurchaseButton;
        private Label shoppingCartListboxLabel;
        private ListBox shoppingCartListbox;
        private Button addToCartButton;
        private Label itemsListboxLabel;
        private ListBox itemsListbox;
        private Label headerText;
        private Label label1venderListboxLabel;
        private ListBox venderListbox;
        private Label storeProfitValue;
        private Label storeProfitLabel;
    }
}