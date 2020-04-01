using Task_3.Models;
using System;

namespace Task_3
{
    
    class Program
    {
        static int RaceCars(Driver driver, Car car)
        {
           return car.CalculateSpeed(driver);
        }

        static Driver SelectDriver(int input)
        {
            Driver greg = new Driver("Greg", 60);
            Driver bob = new Driver("Bob", 50);
            Driver jill = new Driver("Jill", 70);
            Driver anne = new Driver("Anne", 80);

            Driver driver = null;

            switch (input)
            {
                case 1:
                    driver = greg;
                    break;
                case 2:
                    driver = bob;
                    break;
                case 3:
                    driver = jill;
                    break;
                case 4:
                    driver = anne;
                    break;
                default:
                    break;
            }
            return driver;
        }

        static Car SelectCar(int input)
        {
            Car mazda = new Car("Mazda", 260);
            Car hyundai = new Car("Hyundai", 220);
            Car ferrari = new Car("Ferrari", 280);
            Car porsche = new Car("Porsche", 260);

            Car car = null;

            switch (input)
            {
                case 1:
                    car = mazda;
                    break;
                case 2:
                    car = hyundai;
                    break;
                case 3:
                    car = ferrari;
                    break;
                case 4:
                    car = porsche;
                    break;
                default:
                    break;
            }
            return car;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Driver driverOne = null;
                Car carOne = null;
                int scoreOne = 0;
                int inputDriverOne = 0;
                int inputCarOne = 0;

                Driver driverTwo = null;
                Car carTwo = null;
                int inputDriverTwo = 0;
                int inputCarTwo = 0;
                int scoreTwo = 0;
                
                #region First selection and first score
                while (true)
                {
                    Console.WriteLine("Please select a Driver");
                    Console.WriteLine("1. Greg");
                    Console.WriteLine("2. Bob");
                    Console.WriteLine("3. Jill");
                    Console.WriteLine("4. Anne");
                    bool pasreInputDriverOne = int.TryParse(Console.ReadLine(), out inputDriverOne);
                    if (!pasreInputDriverOne || inputDriverOne < 1 || inputDriverOne > 4)
                    {
                        Console.WriteLine("Wrong Input");
                        continue;
                    }
                    else
                    {
                         driverOne = SelectDriver(inputDriverOne);
                    }
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Please select a Car");
                    Console.WriteLine("1. Mazda");
                    Console.WriteLine("2. Hyundai");
                    Console.WriteLine("3. Ferrari");
                    Console.WriteLine("4. Porsche");
                    bool pasreInputCarrOne = int.TryParse(Console.ReadLine(), out inputCarOne);
                    if(!pasreInputCarrOne || inputCarOne < 1 || inputCarOne > 4)
                    {
                        Console.WriteLine("Wrong Input");
                        continue;
                    }
                    else
                    {
                         carOne = SelectCar(inputCarOne);
                    }
                        scoreOne = RaceCars(driverOne, carOne);
                    break;
                }
                #endregion

                #region Second selection and second score
                while (true)
                {
                    Console.WriteLine("Please select a second driver");
                    if (inputDriverOne != 1)
                    {
                        Console.WriteLine("1. Greg");
                    }
                    if (inputDriverOne != 2)
                    {
                        Console.WriteLine("2. Bob");
                    }
                    if (inputDriverOne != 3)
                    {
                        Console.WriteLine("3. Jill");
                    }
                    if (inputDriverOne != 4)
                    {
                        Console.WriteLine("4. Anne");
                    }
                    bool pasreInputDriverTwo = int.TryParse(Console.ReadLine(), out  inputDriverTwo);
                    if(!pasreInputDriverTwo || inputDriverTwo == inputDriverOne || inputDriverTwo < 1 || inputDriverTwo > 4)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }
                    driverTwo = SelectDriver(inputDriverTwo);
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Please select a second car");
                    if (inputCarOne != 1)
                    {
                        Console.WriteLine("1. Mazda");
                    }
                    if (inputCarOne != 2)
                    {
                        Console.WriteLine("2. Hyundai");
                    }
                    if (inputCarOne != 3)
                    {
                        Console.WriteLine("3. Ferrari");
                    }
                    if (inputCarOne != 4)
                    {
                        Console.WriteLine("4. Porsche");
                    }
                    bool pasreInputCarTwo = int.TryParse(Console.ReadLine(), out  inputCarTwo);
                    if (!pasreInputCarTwo || inputCarTwo == inputCarOne || inputCarTwo < 1 || inputCarTwo > 4)
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }
                    else
                    {
                        carTwo = SelectCar(inputCarTwo);
                    }
                    scoreTwo = RaceCars(driverTwo, carTwo);
                    break;
                }
                #endregion

                #region Finale score

                if (scoreOne > scoreTwo)
                {
                    Console.WriteLine($"{driverOne.Name} with {carOne.Model} was driving {carOne.Speed}km/h had a score of {scoreOne} and won the race!!!");
                    Console.WriteLine("Do you want to race again");
                    while (true)
                    {
                        Console.WriteLine("1. YES");
                        Console.WriteLine("2. NO");
                        bool parseNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                        if (!parseNewGame || newGame < 1 || newGame > 2)
                        {
                            Console.WriteLine("Wrong input");
                            continue;
                        }
                        if (newGame == 1)
                        {
                            Console.Clear();
                            break;
                        }
                        if (newGame == 2)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{driverTwo.Name} with {carTwo.Model} was driving {carTwo.Speed}km/h  had a score of {scoreTwo} and won the race!!!");
                    Console.WriteLine("Do you want to race again");
                    while (true)
                    {
                        Console.WriteLine("1. YES");
                        Console.WriteLine("2. NO");
                        bool parseNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                        if (!parseNewGame || newGame < 1 || newGame > 2)
                        {
                            Console.WriteLine("Wrong input");
                            continue;
                        }
                        if (newGame == 1)
                        {
                            Console.Clear();
                            break;
                        }
                        if (newGame == 2)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                    #endregion
            }
        }
    }
}
