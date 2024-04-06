using CafeSystemDemo.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystemDemo
{
    public partial class ProductUI : Form
    {
        private DataBase db;
        private List<Product> product;

        public ProductUI()
        {
            InitializeComponent();
            LoadData();

            db = new DataBase();
        }

        private async Task LoadData()
        {
            await Task.Run(() =>
            {
                LoadProducts();
            });
        }

        private void LoadProducts()
        {
            product = db.GetProducts();

            dgridProducts.Invoke((MethodInvoker)delegate
            {
                dgridProducts.DataSource = product;
            });
        }


        private void btnBackMainUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal productPrice = 0;

            if (!decimal.TryParse(txtProductPrice.Text, out productPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }


            db.AddProduct(productName, productPrice);
            LoadProducts();

            txtProductName.Clear();
            txtProductPrice.Clear();
        }
    }
}
