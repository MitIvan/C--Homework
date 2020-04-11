using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Libary.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        protected int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor() { }

        public Contractor(string firstName, string lastName, Manager responsible, double workHours )
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Contractor;
            Responsible = responsible;
            WorkHours = workHours;
            PayPerHour = 16;
        }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }

    }
}
