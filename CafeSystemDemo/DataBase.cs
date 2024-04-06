using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeSystemDemo.Variables;
using MySql.Data.MySqlClient;

namespace CafeSystemDemo
{
    internal class DataBase
    {
        private readonly string myConnectionString;

        public DataBase()
        {
            // "Server=<YOUR_HOST;DataBase=YOUR_DATABASE;Uid=USERNAME; pwd=PASSWORD>"
            myConnectionString = "";
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM customers";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int tableNumber = reader.IsDBNull("tableNumber") ? -1 : reader.GetInt32("tableNumber");
                            string customerName = reader.GetString("customerName");

                            Customer customer = new Customer(tableNumber, customerName);
                            customers.Add(customer);
                        }
                    }
                }
            }
            Console.WriteLine(customers);
            return customers;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM products";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = reader.GetString("productName");
                            decimal productPrice =  reader.GetDecimal("productPrice");

                            Product product = new Product(productName, productPrice);
                            products.Add(product);
                        }
                    }
                }
            }
            Console.WriteLine(products);
            return products;
        }

        public List<Order> GetOrders(int tableNumber)
        {
            List<Order> orders = new List<Order>();

            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "SELECT *FROM orders WHERE tableNumber LIKE @tableNumber";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableNumber", tableNumber);

                    using(MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string productName = reader.GetString("productName");
                            decimal productPrice = reader.GetDecimal("productPrice");
                            int count = reader.GetInt32("count");

                            Order order = new Order(tableNumber,productName, productPrice, count);
                            orders.Add(order);
                                                  
                        }
                    }
                }
            }
            return orders;
        }
        
        
        public void AddCustomer(int tableNumber, string customerName)
        {
            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO customers (tableNumber, customerName) VALUES (@tableNumber, @customerName)";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableNumber", tableNumber);
                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Custommer Adding");
        }

        public void AddProduct(string productName, decimal productPrice)
        {
            using(MySqlConnection connection = new MySqlConnection(myConnectionString)) 
            {
                connection.Open();

                string query = "INSERT INTO products (productName, productPrice) VALUES (@productName, @productPrice)";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", productPrice);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Product Adding");
        }

        public void AddOrder(int tableNumber, string productName, decimal productPrice, int count)
        {
            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO orders (tableNumber, productName, productPrice, count) VALUES (@tableNumber, @productName, @productPrice, @count)";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableNumber", tableNumber);
                    command.Parameters.AddWithValue("@productName", productName);
                    command.Parameters.AddWithValue("@productPrice", productPrice);
                    command.Parameters.AddWithValue("@count", count);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Add Order");
        }

        public void DeleteCustomer(int tableNumber)
        {
            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM customers WHERE tableNumber = @tableNumber";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableNumber", tableNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOrder(int tableNumber)
        {
            using(MySqlConnection connection = new MySqlConnection(myConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM orders WHERE tableNumber = @tableNumber";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tableNumber", tableNumber);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
