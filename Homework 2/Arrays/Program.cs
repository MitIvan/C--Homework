using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] allNumbers = new int[6];
            
            Console.WriteLine("Enter Integer no.1");
             allNumbers[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Integer no.2");
             allNumbers[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Integer no.3");
             allNumbers[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Integer no.4");
             allNumbers[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Integer no.5");
             allNumbers[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Integer no.6");
             allNumbers[5] = int.Parse(Console.ReadLine());
            
            int sum = 0;
            foreach (int number in allNumbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                };
               
            }
            Console.WriteLine();
            Console.WriteLine("The result is: " + sum);

            Console.ReadLine();

        }

    }
}
