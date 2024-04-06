namespace CafeSystemDemo
{
    partial class Form1
    {

        private void InitializeComponent()
        {
            btnProductUI = new Button();
            btnAddCustomer = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtCustomerName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            numTableNumber = new NumericUpDown();
            dgridCustomer = new DataGridView();
            btnSelectCustomer = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnProductUI
            // 
            btnProductUI.BackColor = SystemColors.ActiveCaption;
            btnProductUI.Location = new Point(66, 92);
            btnProductUI.Name = "btnProductUI";
            btnProductUI.Size = new Size(149, 85);
            btnProductUI.TabIndex = 1;
            btnProductUI.Text = "Products";
            btnProductUI.UseVisualStyleBackColor = false;
            btnProductUI.Click += button1_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(201, 159);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(146, 34);
            btnAddCustomer.TabIndex = 2;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(537, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 3;
            label1.Text = "Cafe Pos System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(806, 122);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "Customers";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numTableNumber);
            groupBox1.Controls.Add(btnAddCustomer);
            groupBox1.Location = new Point(66, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 211);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Customer";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(167, 60);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(180, 31);
            txtCustomerName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 60);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Table Number";
            // 
            // numTableNumber
            // 
            numTableNumber.Location = new Point(167, 105);
            numTableNumber.Name = "numTableNumber";
            numTableNumber.Size = new Size(180, 31);
            numTableNumber.TabIndex = 3;
            // 
            // dgridCustomer
            // 
            dgridCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridCustomer.Location = new Point(555, 150);
            dgridCustomer.Name = "dgridCustomer";
            dgridCustomer.RowHeadersWidth = 62;
            dgridCustomer.Size = new Size(585, 354);
            dgridCustomer.TabIndex = 6;
            dgridCustomer.SelectionChanged += dgridCustomer_SelectionChanged;
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.Location = new Point(806, 510);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(112, 34);
            btnSelectCustomer.TabIndex = 7;
            btnSelectCustomer.Text = "Select!";
            btnSelectCustomer.UseVisualStyleBackColor = true;
            btnSelectCustomer.Click += btnSelectCustomer_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1187, 658);
            Controls.Add(btnSelectCustomer);
            Controls.Add(dgridCustomer);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnProductUI);
            Name = "Form1";
            Text = "Cafe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTableNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnProductUI;
        private Button btnAddCustomer;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private NumericUpDown numTableNumber;
        private Label label3;
        private DataGridView dgridCustomer;
        private Label label4;
        private TextBox txtCustomerName;
        private Button btnSelectCustomer;
    }
}
