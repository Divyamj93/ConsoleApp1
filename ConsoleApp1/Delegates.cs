using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSample
{
    public class Employeee
    {
        private int id;
        private string name;
        private double salary;
        private int experience;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Experience { get => experience; set => experience = value; }

        public Employeee(int id,string name,double salary,int experience)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Experience = experience;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Experience: {Experience}");
        }

        public static List<Employeee> PromotionList(List<Employeee> empList, PromotionCriteria criteria)
        {
            List<Employeee> eligibleEmployees = new List<Employeee>();

            foreach (Employeee emp in empList)
            {
                //if (emp.Experience)
                //{
                    eligibleEmployees.Add(emp);
                //}
            }
            return eligibleEmployees;
        }
    }

    public delegate bool PromotionCriteria(Employeee emp);
    public class UST
    {
        public static bool IsEligibleforPomotion(Employeee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
    public class Infosys
    {
        public static bool IsEligibleforPomotion(Employeee emp)
        {
            if (emp.Experience >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Alliance
    {
        public static bool IsEligibleforPomotion(Employeee emp)
        {
            if (emp.Experience > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
