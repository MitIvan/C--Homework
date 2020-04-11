using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Libary.Models
{
     public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"{FirstName} {LastName}: {Role} - {Salary}$");
            Console.WriteLine("====================================");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        
    }
}
