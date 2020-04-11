using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Libary.Models
{
     public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager() { }

        public Manager(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = 5000;
            Role = Role.Manager;
        }

        public void AddBonus(double bonus)
        {
            Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;
        }

    }
}
