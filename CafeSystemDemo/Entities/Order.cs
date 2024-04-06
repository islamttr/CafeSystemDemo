
namespace CafeSystemDemo.Variables
{
    internal class Order
    {

        // Order' variables
        public int tableNumber { get; set; }
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public int count { get; set; }

        public Order(int tableNumber, string productName, decimal productPrice, int count) 
        {
            this.tableNumber = tableNumber;
            this.productName = productName;
            this.productPrice = productPrice;
            this.count = count;
        }
    }
}
