using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Logger
    {
        public void Log(string className, string methodName, string errorMessage)
        {
            Console.WriteLine($"classname : {className} , methodname: {methodName} , Error: {errorMessage}");
        }

        public void Log(string className, string errorMessage)
        {
            Console.WriteLine($"classname: {className} , Error: {errorMessage}");
        }

        public void Log(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }

        public void Log(string className, string methodName, DateTime dateAndTime, string errorMessage)
        {
            Console.WriteLine($"datetime :{dateAndTime} , classname : {className} , methodname : {methodName} , Error: {errorMessage}");
        }

    }
}
