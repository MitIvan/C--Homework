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
            #region First selection and first score
            Console.WriteLine("Please select a Driver");
            Console.WriteLine("1. Greg");
            Console.WriteLine("2. Bob");
            Console.WriteLine("3. Jill");
            Console.WriteLine("4. Anne");

            bool pasreInputDriverOne = int.TryParse(Console.ReadLine(), out int inputDriverOne);
            Driver driverOne = SelectDriver(inputDriverOne);

            Console.WriteLine("Please select a Car");
            Console.WriteLine("1. Mazda");
            Console.WriteLine("2. Hyundai");
            Console.WriteLine("3. Ferrari");
            Console.WriteLine("4. Porsche");

            bool pasreInputCarrOne = int.TryParse(Console.ReadLine(), out int inputCarOne);
            Car carOne = SelectCar(inputCarOne);
            
            int scoreOne = RaceCars(driverOne, carOne);

            #endregion

            #region Second selection and second score
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

            Driver driverTwo = null;
            bool pasreInputDriverTwo = int.TryParse(Console.ReadLine(), out int inputDriverTwo);
            if(inputDriverTwo != inputDriverOne)
            {
                 driverTwo = SelectDriver(inputDriverTwo);
            }
            else
            {
                Console.WriteLine("Driver already selected");
            }


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

            Car carTwo = null;
            bool pasreInputCarTwo = int.TryParse(Console.ReadLine(), out int inputCarTwo);
            if (inputDriverTwo != inputDriverOne)
            {
                carTwo = SelectCar(inputCarTwo);
            }
            else
            {
                Console.WriteLine("Car already selected");
            }

            int scoreTwo = RaceCars(driverTwo, carTwo);
            #endregion

            #region Finale score
            if (scoreOne > scoreTwo)
            {
                Console.WriteLine($"{driverOne.Name} with {carOne.Model} was driving {carOne.Speed}km/h had a score of {scoreOne} and won the race!!!");
            }
            else
            {
                Console.WriteLine($"{driverTwo.Name} with {carTwo.Model} was driving {carTwo.Speed}km/h  had a score of {scoreTwo} and won the race!!!");
            }

            #endregion;

            Console.ReadLine();
        }
    }
}
