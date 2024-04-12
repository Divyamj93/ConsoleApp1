using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinExample
{
    public class Customer1
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public Customer1(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    public class Order
    {
        private int id;
        private string productName;
        private int customerId;

        public int Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int CustomerId { get => customerId; set => customerId = value; }

        public Order(int id,string productName,int customerId)
        {
            this.Id = id;
            this.ProductName = productName;
            this.CustomerId = customerId;
        }
    }
}
