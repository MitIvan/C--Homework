using System;
using Workshop_Libary.Models;

namespace Workshop_Excercise
{
    class Program
    {
        static void Main(string[] args)
        {


            Manager john = new Manager("John", "Doe");
            Manager boki = new Manager("Boki", "Bobov");
            Contractor koki = new Contractor("Koki", "Kokov", john, 40);
            Contractor viki = new Contractor("Viki", "Vikova", boki, 50);
            SalesPerson martin = new SalesPerson("Martin", "Martinov");

            Employee[] Company = 
            {
                john,
                boki,
                koki,
                viki,
                martin
            };


            //Console.WriteLine($"{Company[0].FirstName}");


            Console.ReadLine();
        }
    }
}
