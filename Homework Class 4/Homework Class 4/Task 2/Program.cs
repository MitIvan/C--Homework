using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter - or +");
                string plusOrMinus = Console.ReadLine();

                if (plusOrMinus == "+" || plusOrMinus == "-")
                {
                    Console.WriteLine("Please enter the first number");
                    bool parseNumA = double.TryParse(Console.ReadLine(), out double numA);

                    if (!parseNumA)
                    {
                        Console.WriteLine("Wrong input must enter a number. Press any key to start again");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    Console.WriteLine("Please enter the second number");
                    bool parseNumB = double.TryParse(Console.ReadLine(), out double numB);

                    if (!parseNumB)
                    {
                        Console.WriteLine("Wrong input must enter a number. Press any key to start again");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (plusOrMinus == "+")
                    {
                        Console.WriteLine(Sum(numA, numB));
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (plusOrMinus == "-")
                    {
                        Console.WriteLine(Subtract(numA, numB));
                        Console.ReadLine();
                        Console.Clear();
                    }

                }
                else
                {
                    Console.WriteLine("Wrong input must enter - of +. Press any key to start again");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                } 
            }
        }
        static string Sum(double numA, double numB)
        {
            double sum = numA + numB;
            return $"The sum of {numA} and {numB} is {sum}";
        }
        static string Subtract(double numA, double numB)
        {
            double subtract = numA - numB;
            return $"The subtract of {numA} and {numB} is {subtract}";
        }
    }
}
