using System;

namespace Task_2
{
    public class Dog
    {
        public string Name;
        public string Race;
        public string Color;

        public void Eat()
        {
            Console.WriteLine($"{Name} is now eating");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"{Name} is now chasing its tail.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dog dog01 = new Dog();

                Console.WriteLine("Please enter the name of the dog");
                dog01.Name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"What race is {dog01.Name}");
                dog01.Race = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"What color is {dog01.Name}");
                dog01.Color = Console.ReadLine();
                Console.Clear();

                while (true)
                {
                    Console.WriteLine("Please select an action for the dog");
                    Console.WriteLine("1. Eat");
                    Console.WriteLine("2. Play");
                    Console.WriteLine("3. Chase tail");
                    Console.WriteLine("4. Exit the app.");
                    bool parseInput = int.TryParse(Console.ReadLine(), out int input);
                    Console.Clear();

                    if (!parseInput || input < 1 || input > 4)
                    {
                        Console.WriteLine("Wrong input Try again");
                        continue;
                    }

                    switch (input)
                    {
                        case 1:
                            Console.Clear();
                            dog01.Eat();
                            break;
                        case 2:
                            Console.Clear();
                            dog01.Play();
                            break;
                        case 3:
                            Console.Clear();
                            dog01.ChaseTail();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Some thing went wrong");
                            break;
                    }
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
