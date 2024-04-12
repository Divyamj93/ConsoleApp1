using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDets
{
    public class Bank
    {
        private string nameOfBank;

        public string NameOfBank { get => nameOfBank; set => nameOfBank = value; }
        public Bank(string nameOfBank)
        {
            this.NameOfBank = nameOfBank;
        }
    }
    public class Customer
    {
        private string name;
        private double balance;
        private Bank bank;

        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public Bank Bank { get => bank; set => bank = value; }

        public Customer(string name, double balance,Bank bank)
        {
            this.name = name;
            this.balance = balance;
            this.bank = bank;
        }
    }
}
