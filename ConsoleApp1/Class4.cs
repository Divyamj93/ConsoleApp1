using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Members
{
    public class Class4
    {
       public void search()
        {
            Employee emp1 = new Employee(12, "Chinju", "chinju@gmail.com", "BE");
            Console.WriteLine("Employee Id : " + emp1.Id);
            Console.WriteLine("Employee Name : " + emp1.Name);
            Console.WriteLine("Employee Email : " + emp1.Email);
            Console.WriteLine("Employee Department : " + emp1.Department);
            Console.ReadLine();

        }
    }
}
