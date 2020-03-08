using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap Numbers");
            Console.WriteLine();
            Console.WriteLine("Enter Number a");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("a = " + firstNum);
            Console.WriteLine();
            Console.WriteLine("Enter Number b");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("b = " + secondNum);
            Console.WriteLine();
            Console.WriteLine("Swapping a and b");

            if(firstNum == secondNum)
            {
                Console.WriteLine("Both numbers have same value");
            } else
            {
                int x = firstNum;
                firstNum = secondNum;
                secondNum = x;

                Console.WriteLine("Number a = " + firstNum);
                Console.WriteLine("Number b = " + secondNum);

            }





            Console.ReadLine();


        }
    }
}
