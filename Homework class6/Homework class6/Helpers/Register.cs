using System;
using System.Collections.Generic;
using System.Text;
using UserAndMessages;

namespace Homework_class6.Helpers
{
    public class Register
    {
        public static void RegisterUser(User[] arrayOfUsers)
        {
            Console.WriteLine("Please enter ID");
            int id;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out id))
            {
                Console.WriteLine("Id must be an Integer");
                input = Console.ReadLine();
            }

            Console.WriteLine("Please enter username");
            string usernameInput = Console.ReadLine();
            foreach (var user in arrayOfUsers)
            {
                while (usernameInput == user.Username)
                {
                    Console.WriteLine($"There is already a user called {usernameInput}");
                    Console.WriteLine("Please enter new username");
                    usernameInput = Console.ReadLine();
                }
            }

            Console.WriteLine("Please enter password");
            string passwordInput = Console.ReadLine();
            while (passwordInput.Length < 3)
            {
                Console.WriteLine("Password length must be > 3");
                passwordInput = Console.ReadLine();
            }

            User newUser = new User(id, usernameInput, passwordInput);

            Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
            arrayOfUsers[arrayOfUsers.Length - 1] = newUser;

            Console.WriteLine("Registration complete !");
            Console.WriteLine("Printing users");

            foreach (var user in arrayOfUsers)
            {
                Console.WriteLine($"{user.Id} {user.Username}");
            }
        }
    }
}
