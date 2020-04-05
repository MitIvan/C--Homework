using Homework_class6.Helpers;
using System;
using UserAndMessages;

namespace Homework_class6
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1, "username1", "12345", new string[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." } );
            User user2 = new User(2, "username2", "asdf", new string[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });
            User user3 = new User(3, "username3", "abcd", new string[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit." });

            User[] arrayOfUsers = new User[]
            {
                user1,
                user2,
                user3
            };

            Console.WriteLine("For log in press 1.");
            Console.WriteLine("For registration press 2.");

            int input;
            bool inputCheck = false;

            while (!inputCheck)
            {
                inputCheck = int.TryParse(Console.ReadLine(), out input);
                if (input == 1)
                {
                    Login.LogIn(arrayOfUsers);
                }
                else if (input == 2)
                {
                    Register.RegisterUser(arrayOfUsers);
                }
                else
                {
                    Console.WriteLine("Wrong input please enter 1 or 2");

                }
            }
            Console.ReadLine();
        }
    }
}
