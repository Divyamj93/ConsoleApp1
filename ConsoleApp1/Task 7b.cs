using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7b
{
    public class Person1
    {
        protected string name;
        protected int age;
        protected string address;
        protected string gender;

        public Person1(string name, int age, string address, string gender)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.gender = gender;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name :{ name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Address :{address}");
            Console.WriteLine($"Gender :{gender}");
        }
    }
    public class Employee1 : Person1
    {
        private string city;
        private string state;

        public Employee1(string name, int age, string address, string gender, string city, string state) : base(name, age, gender, address)
        {
            this.city = city;
            this.state = state;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"City :{city}");
            Console.WriteLine($"State :{state}");
        }
    }
}
