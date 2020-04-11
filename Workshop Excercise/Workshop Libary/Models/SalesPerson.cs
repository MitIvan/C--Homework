using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop_Libary.Models
{
   public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }

        public void ExtendSuccessRevenue(double money)
        {
            SuccessSaleRevenue = money;
        }

        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)
            {
                return Salary += 500;
            } 
            else if(SuccessSaleRevenue >= 2000 && SuccessSaleRevenue <= 5000)
            {
                return Salary += 800;
            }
            else
            {
                return Salary += 2000;
            }
        }
    }

}
