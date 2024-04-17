using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Emplyee
    {
        private int id;
        private string name;
        private double salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public Emplyee(int id,string name,double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        private Dictionary<string, object> strIndexer = new Dictionary<string, object>();
        private List<object> intIndexer = new List<object>();

        public object this[string property]
        {
            get
            {
                if (strIndexer.ContainsKey(property))
                {
                    return strIndexer[property];
                }
                else
                {
                    throw new KeyNotFoundException($"The key '{property}' was not found.");
                }
            }
            set
            {
                strIndexer[property] = value;
            }
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < intIndexer.Count)
                {
                    return intIndexer[index];
                }
                else
                {
                    throw new IndexOutOfRangeException($"The index '{index}' is out of bounds.");
                }
            }
            set
            {
                while (intIndexer.Count <= index)
                {
                    intIndexer.Add(null);
                }

                if (index >= 0 && index < intIndexer.Count)
                {
                    intIndexer[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException($"The index '{index}' is out of bounds.");
                }
            }
        }

        public void Display()
        {
            Console.WriteLine($"Id : {id} , Name : {name} , Salary : {salary}");

            Console.WriteLine("Indexer string Properties");
            foreach (var property in strIndexer)
            {
                Console.WriteLine($"{property.Key}: {property.Value}");
            }
            Console.WriteLine("Indexer integer Properties");
            for (int i = 0; i < intIndexer.Count; i++)
            {
                Console.WriteLine($"{i}: {intIndexer[i]}");
            }
        }

    }

}
