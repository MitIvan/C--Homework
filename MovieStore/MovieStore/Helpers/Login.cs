using MovieStoreLibary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Helpers
{
    public class Login
    {
        public static void LogInEmployee(Employee[] arrayOfEmployees)
        {
            bool corectLogin = false;
            while (!corectLogin)
            {
                Console.WriteLine("Please enter your username:");
                string userName = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Please enter your password");
                string password = Console.ReadLine();
                Console.Clear();

                foreach (var employee in arrayOfEmployees)
                {
                    if(employee.UserName == userName && employee.Password == password)
                    {
                        Console.WriteLine($"Welcome {employee.FirstName}");
                        corectLogin = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong username or Password");
                    }
                }
            }
        }

        public static User LogInUser(User[] arrayOfUsers)
        {
            User foundUser = null;
            if (arrayOfUsers.Length == 0){
                Console.WriteLine("There are no users");
                return foundUser;
            }
            else
            {
                bool corectLogin = false;
                while (!corectLogin)
                {
                    Console.WriteLine("Please enter your username:");
                    string userName = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Please enter your password");
                    string password = Console.ReadLine();
                    Console.Clear();

                    foreach (var user in arrayOfUsers)
                    {
                        if (user.UserName == userName && user.Password == password)
                        {
                            Console.WriteLine($"Welcome {user.FirstName}");
                            corectLogin = true;
                            foundUser = user;
                            return foundUser;
                        }
                        else
                        {
                            Console.WriteLine("Wrong username or Password");
                        }
                    }  
                }
                return foundUser;
            }
        }
    }
}
