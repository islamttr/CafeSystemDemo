using CafeSystemDemo.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystemDemo
{
    public partial class OrderUI : Form
    {
        private int tableNumber;

        private List<Product> products;
        private List<Order> orders;
        private Dictionary<string, decimal> productMap = new Dictionary<string, decimal>();

        private List<string> productName = new List<string>();
        private decimal totalPrice = 0;
        DataBase db;

        public OrderUI(int tableNumber)
        {
            InitializeComponent();
            LoadData();


            db = new DataBase();
            this.tableNumber = tableNumber;
        }

        private async Task LoadData()
        {
            await Task.Run(() =>
            {
                LoadProducts();
                LoadOrders();
                UpdateTotalPrice();
            });
        }


        private void LoadProducts()
        {

            if (db == null)
            {
                db = new DataBase();
                products = db.GetProducts();
            }
            else
            {
                products = db.GetProducts();
            }

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                productMap.Add(product.productName, product.productPrice);

                productName.Clear();
                foreach (var key in productMap.Keys)
                {
                    productName.Add(key);
                }
            }

            cmboxProduct.Invoke((MethodInvoker)delegate
            {
                cmboxProduct.DataSource = productName;

            });
        }

        private void LoadOrders()
        {
            orders = db.GetOrders(tableNumber);

            dgridOrders.Invoke((MethodInvoker)delegate
            {
                dgridOrders.DataSource = orders;
            });
        }

        private void UpdateTotalPrice()
        {
            totalPrice = 0;
            foreach (DataGridViewRow row in dgridOrders.Rows)
            {
                int count = Convert.ToInt32(row.Cells["count"].Value);
                decimal price = Convert.ToDecimal(row.Cells["productPrice"].Value);

                decimal multiply = count * price;

                totalPrice += multiply;
            }
            
            lblTotalPrice.Invoke((MethodInvoker)delegate
            {
                lblTotalPrice.Text = "Total Price: " + totalPrice.ToString();
            });
        }

        private void btnBackMainUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string productname = cmboxProduct.Text;
            decimal productPrice = 0;
            int count = Convert.ToInt32(numCount.Value);

            productMap.TryGetValue(productname, out productPrice);

            db.AddOrder(tableNumber, productname, productPrice, count);

            LoadOrders();
            UpdateTotalPrice();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            db.DeleteOrder(tableNumber);
            db.DeleteCustomer(tableNumber);

            UpdateTotalPrice();

            

            this.Close();
        }
    }
}
