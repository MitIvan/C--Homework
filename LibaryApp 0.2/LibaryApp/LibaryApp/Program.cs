using LibraryApp.Models.Book;
using LibraryApp.Models.User;
using LibraryApp.Services;
using System;
using System.Collections.Generic;

namespace LibaryApp
{
    class Program
    {

        // 1. Folder structure for our app --- done
        // 2. Create domain models for User and Book --- done
        // 3. Create User and Book services --- done
        // 4. Create methods in the coresponding services --- done
        // 5. Write the login or register flow (console questions) --- done
        // 6. Add validation --- done
        // 7. Inheritance of classes --- done
        // TO DO
        // 8. Use collections (List) --- done
        // 9. Change Login & Register methods --- done
        // 10. Plus features of our library --- done
        // 11. Improve UI flow ----------> // HOMEWORK
        private static UserService _userService = new UserService();
        private static HelperService _helperService = new HelperService();
        private static UIService _uiService = new UIService();
        private static BookService _bookService = new BookService();

        private static User _loggedUser = null;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our LibraryApp");
            while (true)
            {
                // Main flow (questions)
                Console.WriteLine("Do you want to login or register ? ");
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Register");
                Console.WriteLine("3) Exit");
                int userChoice = _helperService.ValidatePositiveNumber(Console.ReadLine(), 3);

                //1.Login flow
                if (userChoice == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Username");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string password = Console.ReadLine();

                        _loggedUser = _userService.LogIn(username, password);

                        if (_loggedUser == null)
                        {
                            _helperService.ErrorMessage("Wrong username or password");
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }

                else if (userChoice == 2)
                {
                    _loggedUser = _uiService.RegisterFlow();
                }

                else if(userChoice == 3)
                {
                    _helperService.LogOffOrExit(_loggedUser);
                    Console.Clear();
                    break;
                }

                // Different flows for User and Admin
                if (_loggedUser.Role == Role.Admin)
                {
                    // Imporove admin flow
                    // Display welcome message ... Select specific option 
                    // 1. Add new user
                    // 2. Delete a user
                    // 3. Print all users

                    //** (optional) add while infinite control // HOMEWORK
                    //Ja promeniv runAgain metodata vo LogOffOrExit. 
                    //Sega userot moze da napravi log off i da se vrati na startot od aplikacijata za da moze dr user da se logira 
                    //ili da izleze od app ako ja izbere 3-tata opija

                    bool exit = false;
                    while (!exit)
                    {
                        _loggedUser.GreetPerson($"Welcome mr/mrs. {_loggedUser.LastName}");
                        Console.WriteLine("Please select one of the following options: ");
                        Console.WriteLine("1) Register a new user");
                        Console.WriteLine("2) Delete a user");
                        Console.WriteLine("3) Print all users");
                        Console.WriteLine("4) Log off");

                        string selectedOption = Console.ReadLine();

                        switch (selectedOption)
                        {
                            case "1":
                                _uiService.RegisterFlow();
                                break;

                            case "2":
                                Console.WriteLine("Please enter the ID of the user you want to delete");
                                int id = int.Parse(Console.ReadLine());
                                _userService.RemoveUserById(id);
                                break;

                            case "3":
                                _userService.PrintUsers();
                                break;

                            case "4":
                                exit = _helperService.LogOffOrExit(_loggedUser);
                                _loggedUser = null;
                                break;

                            default:
                                Console.WriteLine("You have entered a non existing option");
                                break;
                        }
                    }

                }

                else if (_loggedUser.Role == Role.User)
                {
                    // Imporove admin flow
                    // Display welcome message ... Select specific option 
                    // 1. Show my books
                    // 2. Show all books
                    // 3. Rent a book
                    // 4. Return a book

                    bool exit = false;
                    while (!exit)
                    {
                        _loggedUser.GreetPerson($"Welcome mr/mrs. {_loggedUser.LastName}");
                        Console.WriteLine("Please select one of the following options: ");
                        Console.WriteLine("1) Show my books");
                        Console.WriteLine("2) Show all books");
                        Console.WriteLine("3) Rent a book"); // HOMEWORK
                        Console.WriteLine("4) Return a book"); // HOMEWORK
                        Console.WriteLine("5) Log off");

                        string selectedOption = Console.ReadLine();

                        switch (selectedOption)
                        {
                            case "1":
                                try
                                {
                                    List<Book> userBooks = _userService.GetBooksByUserId(_loggedUser.Id);
                                    //if (userBooks.Count() > 0)
                                    if (userBooks != null && userBooks.Count != 0)
                                    {
                                        userBooks.ForEach(x => Console.WriteLine(x.Title));
                                    }
                                    else
                                    {
                                        Console.WriteLine("You haven't rented a book yet !");
                                    }
                                }
                                catch (NullReferenceException ex)
                                {
                                    Console.WriteLine("Value can't be null!");
                                    Console.WriteLine($"Original message: {ex.Message}");
                                }

                                break;
                            case "2":
                                _bookService.PrintAllBooks();
                                break;

                            case "3":
                                _bookService.RentABook(_loggedUser);
                                break;

                            case "4":
                                _bookService.ReturABook(_loggedUser);
                                break;
                            case "5":
                               exit = _helperService.LogOffOrExit(_loggedUser);
                                _loggedUser = null;
                                break;

                            default:
                                Console.WriteLine("You have entered a non existing option");
                                break;
                        }
                    }
                }
                else
                {
                    _helperService.ErrorMessage("Something went wrong... Please try again!");
                }
            }

        }
    }
}
