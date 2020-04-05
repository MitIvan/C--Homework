using System;
using System.Collections.Generic;
using System.Text;
using UserAndMessages;

namespace Homework_class6.Helpers
{
    public class Login
    {
        public static void LogIn(User[] arrayOfUsers)
        {
            int errorCouter = 0;

            while (errorCouter < 3)
            {
                Console.WriteLine("Please enter username");
                string userNameInput = Console.ReadLine();

                Console.WriteLine("Please enter password");
                string passwordInput = Console.ReadLine();

                bool loginCheck = false;

                while (!loginCheck)
                {
                    foreach (var user in arrayOfUsers)
                    {
                        if (user.Username == userNameInput && user.Password == passwordInput)
                        {
                            Console.WriteLine($"Welcome {user.Username} here are your messages");
                            loginCheck = true;
                            errorCouter = 3;
                            foreach (var mesage in user.Mesages)
                            {
                                Console.WriteLine($"{mesage}");
                            }
                        }
                    }
                    if (!loginCheck)
                    {
                        Console.WriteLine("Wrong username or password");
                        Console.WriteLine("Please try again");
                        errorCouter++;
                        break;
                    }
                }
            }
        }
    }
}
