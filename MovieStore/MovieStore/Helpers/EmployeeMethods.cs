using MovieStoreLibary.Models;
using MovieStoreLibary.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieStore.Helpers
{
    public class EmployeeMethods
    {
        #region Register Employee
        public static Employee[] RegisterEmployee(Employee[] arrayOfEmployees)
        {
            Console.WriteLine("Please Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter age");
            bool parseAge = int.TryParse(Console.ReadLine(), out int age);
            while (!parseAge)
            {
                Console.WriteLine("Incorrect value try again ");
                parseAge = int.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine("Please enter username");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Please enter phone number");
            bool parsePhoneNumber = int.TryParse(Console.ReadLine(), out int phoneNumber);
            while (!parsePhoneNumber)
            {
                Console.WriteLine("Incorrect value try again ");
                parsePhoneNumber = int.TryParse(Console.ReadLine(), out phoneNumber);
            }

            DateTime registrationDate = DateTime.Today;

            Console.WriteLine("Please enter working hours per month");
            bool parseHoursPerMonth = int.TryParse(Console.ReadLine(), out int hoursPerMonth);
            while (!parseHoursPerMonth)
            {
                Console.WriteLine("Incorrect value try again ");
                parseHoursPerMonth = int.TryParse(Console.ReadLine(), out hoursPerMonth);
            }

            Employee newEmployee = new Employee(hoursPerMonth, firstName, lastName, age, userName, password, phoneNumber, registrationDate);

            Array.Resize(ref arrayOfEmployees, arrayOfEmployees.Length + 1);
            arrayOfEmployees[arrayOfEmployees.Length - 1] = newEmployee;
            
            return arrayOfEmployees;

        }
        #endregion

        #region Register user
        public static User[] RegisterUser(User[] arrayOfUsers)
        {
            Console.WriteLine("Please Enter Id");
            string id = Console.ReadLine();

            Console.WriteLine("Please Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please Enter Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter age");
            bool parseAge = int.TryParse(Console.ReadLine(), out int age);
            while (!parseAge)
            {
                Console.WriteLine("Incorrect value try again ");
                parseAge = int.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine("Please enter username");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();

            Console.WriteLine("Please enter phone number");
            bool parsePhoneNumber = int.TryParse(Console.ReadLine(), out int phoneNumber);
            while (!parsePhoneNumber)
            {
                Console.WriteLine("Incorrect value try again ");
                parsePhoneNumber = int.TryParse(Console.ReadLine(), out phoneNumber);
            }

            Console.WriteLine("Please chose subscription type");
            Console.WriteLine("1. Monthly");
            Console.WriteLine("2. Annually");
            bool parseSubscription = int.TryParse(Console.ReadLine(), out int subscriptionInput);
            TypeOfSubscription subscription = TypeOfSubscription.Monthly;
            while (!parseSubscription)
            {
                if (subscriptionInput == 1)
                {
                    subscription = TypeOfSubscription.Monthly;
                }
                else if (subscriptionInput == 2)
                {
                    subscription = TypeOfSubscription.Annually;
                }
                else
                {
                    Console.WriteLine("Incorrect value try again ");
                    parseSubscription = int.TryParse(Console.ReadLine(), out subscriptionInput);
                }

            }

            DateTime registrationDate = DateTime.Today;

            User newUser = new User(id, subscription, firstName, lastName, age, userName, password, phoneNumber, registrationDate);

            Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
            arrayOfUsers[arrayOfUsers.Length - 1] = newUser;
            
            return arrayOfUsers;
        }
        #endregion

        #region Delete User
        public static User[] deleteUser(User[] arrayOfUsers)
        {
            Console.WriteLine("Please enter username for deletion");
            string username = Console.ReadLine();
            int indexToRemove = 0;
            foreach (var user in arrayOfUsers)
            {
                if (user.UserName == username)
                {
                    indexToRemove = Array.IndexOf(arrayOfUsers, user);
                }
            }
            // Ova ne znam sto pravi go vidov na stackoverflow ama raboti :D:D:D konecno
            arrayOfUsers = arrayOfUsers.Where((source, index) => index != indexToRemove).ToArray();

            return arrayOfUsers;
            #endregion
        }
    }
}
