using System;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome dear customer! Please select a drink:");
            Console.WriteLine("1. Espresso...........2$");
            Console.WriteLine("2. Macchiato........3,5$");
            Console.WriteLine("3. Latte..............4$");
            Console.WriteLine("4. Cappuccino.........6$");
            Console.WriteLine("5. Tea..............1,5$");
            int input;
            bool parseInput = int.TryParse(Console.ReadLine(), out input);

            if (!parseInput)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else if (input < 0 || input > 5)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else
            {
                switch (input)
                {
                    case 1:
                        CalculatePrice(2, "Espreso");
                        
                        break;
                    case 2:
                        CalculatePrice(3.5, "Macchiato");

                        break;
                    case 3:
                        CalculatePrice(4, "Latte");
                        break;
                    case 4:
                        CalculatePrice(6, "Cappuccino");
                        break;
                    case 5:
                        CalculatePrice(1.5, "Tea");
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
        static void CalculatePrice(double price, string product)
        {
            Console.WriteLine("Please insert " + price + " $");
            double inputPrice;
            bool parseInputPrice = double.TryParse(Console.ReadLine(), out inputPrice);
            if (!parseInputPrice)
            {
                Console.WriteLine("Please enter the corect input");
            }
            else
            {
                if (inputPrice < price)
                {
                    double addMoney = price - inputPrice;
                    Console.WriteLine("The " + product + " costs " + price +  " you are missing " + addMoney + "$" + " to buy it");
                }
                else if (inputPrice > price)
                {
                    double returnMoney = inputPrice - price;
                    Console.WriteLine("The " + product + " costs " + price + " here is your change of " + returnMoney + "$");
                }
                else
                {
                    Console.WriteLine("Thank you");
                }
            }
        }
    }

}
