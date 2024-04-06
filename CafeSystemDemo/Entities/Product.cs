using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystemDemo.Variables
{
    internal class Product
    {
        // Product' variables
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        
        public Product(string productName, decimal productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }
    }
}
