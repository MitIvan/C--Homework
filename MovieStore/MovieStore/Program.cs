using MovieStoreLibary.Models;
using MovieStoreLibary.Enums;
using System;
using MovieStore.Helpers;

namespace MovieStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ivan = new Employee(300, "Ivan", "Mitev", 29, "a", "1", 070123456, new DateTime(2020, 4, 26));
            Employee[] arrayOfEmployees = { ivan };
            
            User[] arrayOfUsers = { };

            Movie lotr1 = new Movie("Lord of the rings, The fellowship of the ring", "9/10", 2001, Genre.Adventure);
            Movie rambo1 = new Movie("First blood ", "8/10", 1982, Genre.Action);
            Movie sw = new Movie("sw", "8/10", 2017, Genre.SciFi);

            Movie[] arrayOfMovies = { lotr1, rambo1, sw };

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("MOVIE STORE inc.");
                Console.WriteLine("Welcome to MOVIE STORE inc. If you are an employee press 1, If you are user press 2!");
                Console.WriteLine("1. Employee");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");

                bool inputCheck = false;
                while (!inputCheck)
                {
                    inputCheck = int.TryParse(Console.ReadLine(), out int input);
                    #region Employee
                    if (input == 1)
                    {
                        Console.Clear();
                        Login.LogInEmployee(arrayOfEmployees);

                        bool employeeExit = false;
                        while (!employeeExit)
                        {
                            Console.Clear();
                            Console.WriteLine("Please chose action");
                            Console.WriteLine("1. Register new Employee");
                            Console.WriteLine("2. Register new User");
                            Console.WriteLine("3. See all the movies available for renting");
                            Console.WriteLine("4. Delete User");
                            Console.WriteLine("5. Log out");

                            bool  employeeCheck = int.TryParse(Console.ReadLine(), out int employeeInput);
                            if(employeeInput == 1)
                            {
                                Console.Clear();
                                arrayOfEmployees = EmployeeMethods.RegisterEmployee(arrayOfEmployees);
                                Console.WriteLine("Employee added");
                                Console.ReadLine();
                                Console.Clear();

                            }
                            else if(employeeInput == 2)
                            {
                                Console.Clear();
                                arrayOfUsers = EmployeeMethods.RegisterUser(arrayOfUsers);
                                Console.WriteLine("User added");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(employeeInput == 3)
                            {
                                Console.Clear();
                                foreach (var movie in arrayOfMovies)
                                {
                                    Console.WriteLine($"{movie.Title}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (employeeInput == 4)
                            {
                                if(arrayOfUsers.Length == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("There are no users");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    arrayOfUsers = EmployeeMethods.deleteUser(arrayOfUsers);
                                    Console.WriteLine("User Deleted");
                                    Console.ReadLine();
                                    Console.Clear();
                                }  
                            }
                            else if (employeeInput == 5)
                            {
                                employeeExit = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong input");
                            }
                        }
                    }
                    #endregion

                    #region User
                    else if (input == 2)
                    {
                        Console.Clear();
                        User logedUser =  Login.LogInUser(arrayOfUsers);
                        bool userExit = false;
                        while (!userExit)
                        {
                            Console.Clear();
                            Console.WriteLine("Please chose action");
                            Console.WriteLine("1. See info");
                            Console.WriteLine("2. Rent a movie");
                            Console.WriteLine("3. Log out");
                           
                            bool userCheck = int.TryParse(Console.ReadLine(), out int userInput);
                            if(userInput == 1)
                            {
                                logedUser.DisplayInfo();
                                Console.WriteLine($"You are { logedUser.SubscriptionType} subscriber");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if(userInput == 2)
                            {
                                arrayOfMovies = UserMethods.RentMovie(arrayOfMovies, logedUser);

                                //string[] userMoies = new string[] { };

                                 //Array.Resize(ref logedUser.RentedMovies, userMoies.Length + 1);
                                //userMoies[userMoies.Length - 1] = rentedMoie;

                                Console.ReadLine();
                                Console.WriteLine($"Movie rented : {logedUser.RentedMovies[0].Title}");
                                Console.Clear();
                            }
                            else if(userInput == 3)
                            {
                                userExit = true;
                            }
                        }
                    }else if( input == 3 )
                    {
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input! Press 1, 2 or 3");
                    }
                    #endregion
                }

            }
            Console.ReadLine();
        }
    }
}
