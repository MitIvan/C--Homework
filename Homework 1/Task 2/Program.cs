using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the average number");
            Console.WriteLine();

            Console.WriteLine("Enter the first number");
            float firstNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            float secondNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            float thirdNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number");
            float fourthNum = float.Parse(Console.ReadLine());

            float averageNum = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine("The Average is " + averageNum);

            Console.ReadLine();

        }
    }
}
