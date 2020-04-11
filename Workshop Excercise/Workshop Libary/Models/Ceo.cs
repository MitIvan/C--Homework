using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Libary.Models
{
    public class Ceo : Employee
    {
        public Employee[] Employees = new Employee[] { };
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public Ceo() { }

        public Ceo(string firstName, string lastName, int shares) 
        {
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Salary = 10000;
            Role = Role.Ceo;
        }

        public double AddSharesPrice(double sharePrice)
        {
            SharesPrice = sharePrice;
            return SharesPrice;
        }

        public void PrintEmployees(Employee[] arrayOfEmployees)
        {
            Console.WriteLine("Employees:");
            foreach (var employee in arrayOfEmployees)
            {
                employee.PrintInfo();
            }
        }

        public override double GetSalary()
        {
            return Salary += Shares * SharesPrice;
        }

    }
}
