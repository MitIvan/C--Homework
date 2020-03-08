using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            
            Console.WriteLine("Enter Number");
            float numX = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter one of the following operations ( +, - , * , /)");
            string mathOperator = Console.ReadLine();

            Console.WriteLine("Enter Number");
            float numY = float.Parse(Console.ReadLine());

            float sum = 0;

            switch (mathOperator)
            {
                case "+":
                    sum = numX + numY;
                    Console.WriteLine(numX + " " + mathOperator + " " + numY + " = " + sum);
                    break;
                case "-":
                    sum = numX - numY;
                    Console.WriteLine(numX + " " + mathOperator + " " + numY + " = " + sum);
                    break;
                case "*":
                    sum = numX * numY;
                    Console.WriteLine(numX + " " + mathOperator + " " + numY + " = " + sum);
                    break;
                case "/":
                    sum = numX / numY;
                    Console.WriteLine(numX + " " + mathOperator + " " + numY + " = " + sum);
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }

            Console.ReadLine();
        }
    }
}
