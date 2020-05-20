using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace LibraryApp.Models.User
{
    public class User
    {
        private static int _idGenerator = 0;
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }

        public List<Book.Book> Books { get; set; }

        public User()
        {
            Role = Role.User;
           
        }

        public User(string fName, string lName, string uName, string pass)
        {
            _idGenerator++;
            
            Id = _idGenerator;
            FirstName = fName;
            LastName = lName;
            Username = uName;
            Password = pass;
            Role = Role.User;
            Books = new List<Book.Book>();
        }

        public string GreetPerson(string message)
        {
            return $"Hello {FirstName} welcome to the Library App";
        }

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }
}
