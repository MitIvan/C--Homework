using System;

namespace Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10; i < 100; i++)
            {
                int tens = i / 10;
                int ones = i % 10;
                if(tens > ones)
                {
                    Console.WriteLine(i);
                }
            }
 
            Console.ReadLine();

        }
    }
}
