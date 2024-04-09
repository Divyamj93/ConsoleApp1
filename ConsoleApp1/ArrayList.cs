using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User1
    {
        private int id;
        private string name;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public User1(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}";
        }
    }
}
