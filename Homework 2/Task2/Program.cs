using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a student group. 1 or 2");

            int studentGroup = int.Parse(Console.ReadLine());
            
            string[] g1 = {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
            string[] g2 = { "Igor", "Dejan", "Martin", "Ivan", "Davor" };


            switch (studentGroup)
            {
                case 1: 
                    foreach(string student in g1)
                    {
                        Console.WriteLine(student);
                    }
                    break;

                case 2:
                    foreach(string student in g2)
                    {
                        Console.WriteLine(student);
                    }
                    break;

                default:
                    Console.WriteLine("Please enter the right group");
                    break;
            }



            Console.ReadLine();
        }
    }
}
