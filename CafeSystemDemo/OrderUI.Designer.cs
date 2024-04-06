namespace CafeSystemDemo
{
    partial class OrderUI
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
            lblTotalPrice = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnOrder = new Button();
            numCount = new NumericUpDown();
            cmboxProduct = new ComboBox();
            btnPay = new Button();
            btnBackMainUI = new Button();
            dgridOrders = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridOrders).BeginInit();
            SuspendLayout();
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(1019, 513);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(110, 25);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "Total Price: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnOrder);
            groupBox1.Controls.Add(numCount);
            groupBox1.Controls.Add(cmboxProduct);
            groupBox1.Location = new Point(33, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 249);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Order";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 128);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Count";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 69);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "Product";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(229, 188);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(112, 34);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order!";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // numCount
            // 
            numCount.Location = new Point(161, 122);
            numCount.Name = "numCount";
            numCount.Size = new Size(180, 31);
            numCount.TabIndex = 1;
            // 
            // cmboxProduct
            // 
            cmboxProduct.FormattingEnabled = true;
            cmboxProduct.Location = new Point(161, 61);
            cmboxProduct.Name = "cmboxProduct";
            cmboxProduct.Size = new Size(182, 33);
            cmboxProduct.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(517, 590);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(112, 34);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnBackMainUI
            // 
            btnBackMainUI.BackColor = SystemColors.ActiveCaption;
            btnBackMainUI.Location = new Point(33, 30);
            btnBackMainUI.Name = "btnBackMainUI";
            btnBackMainUI.Size = new Size(223, 70);
            btnBackMainUI.TabIndex = 4;
            btnBackMainUI.Text = "Back Main Menu";
            btnBackMainUI.UseVisualStyleBackColor = false;
            btnBackMainUI.Click += btnBackMainUI_Click;
            // 
            // dgridOrders
            // 
            dgridOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridOrders.Location = new Point(561, 135);
            dgridOrders.Name = "dgridOrders";
            dgridOrders.RowHeadersWidth = 62;
            dgridOrders.Size = new Size(614, 354);
            dgridOrders.TabIndex = 5;
            // 
            // OrderUI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 658);
            Controls.Add(dgridOrders);
            Controls.Add(btnBackMainUI);
            Controls.Add(btnPay);
            Controls.Add(groupBox1);
            Controls.Add(lblTotalPrice);
            Name = "OrderUI";
            Text = "OrderUI";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTotalPrice;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button btnOrder;
        private NumericUpDown numCount;
        private ComboBox cmboxProduct;
        private Button btnPay;
        private Button btnBackMainUI;
        private DataGridView dgridOrders;
    }
}