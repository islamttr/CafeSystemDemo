using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSystemDemo.Variables
{
    internal class Customer
    {
        // customer' variables
        public int tableNumber {  get; set; }
        public string customerName { get; set; }

        public Customer(int tableNumber, string customerName) 
        {
            this.tableNumber = tableNumber;
            this.customerName = customerName;
        }
    }
}
