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
        private string company;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Experience { get => experience; set => experience = value; }
        public string Company { get => company; set => company = value; }

        public Employeee(int id,string name,double salary,int experience,string company)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Experience = experience;
            this.Company = company;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Experience: {Experience} years, Company: {Company}");
        }

        public static List<Employeee> PromotionList(List<Employeee> empList, PromotionCriteria criteria, string companyName)
        {
            List<Employeee> eligibleEmployees = new List<Employeee>();

            foreach (Employeee emp in empList)
            {
                if (emp.Company == companyName && criteria(emp.Experience))
                {
                    eligibleEmployees.Add(emp);
                }
            }
            return eligibleEmployees;
        }
    }

    public delegate bool PromotionCriteria(int experience);
    public class UST
    {
        public static bool Eligible(int experience)
        {
            if (experience > 5)
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
        public static bool Eligible(int experience)
        {
            if (experience > 3)
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
        public static bool Eligible(int experience)
        {
            if (experience > 6)
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
