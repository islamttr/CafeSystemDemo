namespace CafeSystemDemo
{
    partial class ProductUI
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            btnBackMainUI = new Button();
            dgridProducts = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Location = new Point(79, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 159);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 3;
            label2.Text = "Product Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 72);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(154, 153);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(150, 31);
            txtProductPrice.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(154, 72);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(150, 31);
            txtProductName.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(166, 454);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(153, 38);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnBackMainUI
            // 
            btnBackMainUI.BackColor = SystemColors.ActiveCaption;
            btnBackMainUI.Location = new Point(85, 34);
            btnBackMainUI.Name = "btnBackMainUI";
            btnBackMainUI.Size = new Size(199, 73);
            btnBackMainUI.TabIndex = 5;
            btnBackMainUI.Text = "Back Main Menu";
            btnBackMainUI.UseVisualStyleBackColor = false;
            btnBackMainUI.Click += btnBackMainUI_Click;
            // 
            // dgridProducts
            // 
            dgridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridProducts.Location = new Point(548, 135);
            dgridProducts.Name = "dgridProducts";
            dgridProducts.RowHeadersWidth = 62;
            dgridProducts.Size = new Size(579, 388);
            dgridProducts.TabIndex = 6;
            // 
            // ProductUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 658);
            Controls.Add(dgridProducts);
            Controls.Add(btnBackMainUI);
            Controls.Add(btnAddProduct);
            Controls.Add(groupBox1);
            Name = "ProductUI";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private Button btnBackMainUI;
        private DataGridView dgridProducts;
    }
}