using CafeSystemDemo.Variables;
using System.Windows.Forms;

namespace CafeSystemDemo
{
    public partial class Form1 : Form
    {
        private DataBase db;
        private List<Customer> customers;
        private int tableNumber;

        public Form1()
        {
            InitializeComponent();
            LoadData();

            db = new DataBase();

        }

        private async Task LoadData()
        {
            await Task.Run(() =>
            {
                LoadCustomers();
            });
        }

        public void LoadCustomers()
        {
            customers = db.GetCustomers();

            dgridCustomer.Invoke((MethodInvoker)delegate
            {
                dgridCustomer.DataSource = customers;
                dgridCustomer.ReadOnly = true;
                                
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductUI product = new ProductUI();
            product.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int tableNumber = Convert.ToInt32(numTableNumber.Value);
            string customerName = txtCustomerName.Text.Trim();

            db.AddCustomer(tableNumber, customerName);
            LoadCustomers();

            txtCustomerName.Clear();
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {

            OrderUI order = new OrderUI(tableNumber);
            order.ShowDialog();
        }

        private void dgridCustomer_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                object cellValue = dgridCustomer.CurrentRow.Cells[0].Value;

                tableNumber = (int)cellValue;
            }
            catch
            {

            }
        }
    }
}
