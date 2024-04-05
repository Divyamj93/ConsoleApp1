using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7a
{
    //Define a class Person with some fields and method display and show
    public class Person
    {
        private string name;
        private int age;
        private string address;
        private string gender;

        public Person(string name,int age,string address,string gender)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.gender = gender;
        }

        public void Display()
        {
            Console.WriteLine($"Name :{ name}");
            Console.WriteLine($"Age :{age}");
            Console.WriteLine($"Address :{address}");
            Console.WriteLine($"Gender :{gender}");
        }
    }
}
