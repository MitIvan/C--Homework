using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Substrings();
                Console.ReadLine();
            }
        }

        static void Substrings()
        {

            string hello = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine(hello);
            Console.WriteLine($"Please enter a number between 1 and {hello.Length}");
            
            bool parseInput = int.TryParse(Console.ReadLine(), out int input);
            if (!parseInput || input < 1 || input > hello.Length )
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                char[] characters = hello.ToCharArray();
                Console.WriteLine($@"The character ""{characters[input - 1]}"" is at place {input}");

                string substring = hello.Substring(0, input);
                Console.WriteLine($@"The first {input} characters are ""{substring}"" and the length of this substring is {substring.Length}");
            }
            
        }
    }
}
