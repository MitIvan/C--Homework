using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime today = DateTime.Today;

            DateTime daysFromNow3 = today.AddDays(3);
            DateTime monthFromNow = today.AddMonths(1);
            DateTime monttAndThreeDays = today.AddMonths(1).AddDays(3);
            DateTime yearAndTwoMonthsAgo = today.AddYears(-1).AddMonths(-2);
            string currentMonth = string.Format("The current month is {0:MM}", today);
            string currentYear = string.Format("The current year is {0:yyyy}", today);


            Console.WriteLine($"The date that is 3 days from now is {daysFromNow3}");
            Console.WriteLine($"The date that is one month from now is {monthFromNow}");
            Console.WriteLine($"The date that is one month three days from now is {monttAndThreeDays}");
            Console.WriteLine($"The date that is  1 year and 2 months ago from today {yearAndTwoMonthsAgo}");
            Console.WriteLine(currentYear);
            Console.WriteLine(currentMonth);

            Console.ReadLine();
        }
    }
}
