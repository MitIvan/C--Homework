using MovieStoreLibary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibary.Models
{
    public class Employee : Members
    {
        protected double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public double? Bonus { get; set; }

        public Employee() 
        {
            Salary = 300;
            Role = Role.Employee;
        }

        public Employee(int hoursPerMonth, string firstName, string lastName, int age, string userName, string password, long phoneNumber, DateTime dateOfRegistration)
        {
            HoursPerMonth = hoursPerMonth;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            
        }

        public void SetBonus()
        {
            if(HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else
            {
                Bonus = null;
            }
        }

        public void SetSalary()
        {
            if(Bonus is double bonusValue)
            {
                Salary += HoursPerMonth * bonusValue;
                Console.WriteLine($"{FirstName} {LastName} salary is {Salary}");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} salary is {Salary}");
            }
        }

    }
}
