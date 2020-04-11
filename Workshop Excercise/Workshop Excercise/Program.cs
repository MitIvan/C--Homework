using System;
using Workshop_Libary.Models;

namespace Workshop_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {


            Manager john = new Manager("John", "Doe");
            john.AddBonus(1000);
            john.GetSalary();
            Manager boki = new Manager("Boki", "Bobov");
            boki.AddBonus(1200);
            boki.GetSalary();
            Contractor koki = new Contractor("Koki", "Kokov", john, 40);
            koki.GetSalary();
            Contractor viki = new Contractor("Viki", "Vikova", boki, 50);
            viki.GetSalary();
            SalesPerson martin = new SalesPerson("Martin", "Martinov");
            martin.ExtendSuccessRevenue(3000);
            martin.GetSalary();

            Employee[] companyEmployees = 
            {
                john,
                boki,
                koki,
                viki,
                martin
            };

            Ceo trump = new Ceo("Donald", "Trump", 7000);
            trump.AddSharesPrice(100);
            trump.GetSalary();
            trump.PrintInfo();
            trump.PrintEmployees(companyEmployees);



            Console.ReadLine();
        }
    }
}
