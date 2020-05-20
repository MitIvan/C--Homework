using LibraryApp.Models.Book;
using LibraryApp.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryApp.Services
{
    public class BookService
    {
        public List<Book> Books { get; set; }
        public BookService()
        {
            Books = new List<Book>
            {
                new EBook("Harry Potter and the goblet of fire", "Bob", Genres.Adventure, 200, "adventure/harrypotterseries", 50),
                new EBook("Spiderman", "John", Genres.ComicBook, 300, "comics/spideran", 30),
                new EBook("Star Wars", "Jack", Genres.Adventure, 400, "adventure/starwarsseries", 100),

                new HardCoverBook("Best book ever", "Kika", Genres.Adventure, 500, 10 , DateTime.Now),
                new HardCoverBook("How to be React master?", "Dejan", Genres.Adventure, 600, 3 , DateTime.Now),
                new HardCoverBook("Not so good book", "Petko", Genres.Novel, 1000, 30, DateTime.Now)
            };
        }
        public void PrintAllBooks()
        {
            if (Books.Count() == 0)
            {
                Console.WriteLine("There are no books yet");
                return;
            }
            Books.ForEach(book => Console.WriteLine(book.BookInfo()));
        }

        public void RentABook(User user)
        {
            Console.WriteLine("Please enter the ID of the book you want to rent");
            Books.ForEach(x => Console.WriteLine($"{x.Id}----{x.Title}"));
            bool idParse = int.TryParse(Console.ReadLine(), out int id );
            Book foundBook = Books.FirstOrDefault(book => book.Id == id);
            if(foundBook != null)
            {
                user.Books.Add(foundBook);
                Console.WriteLine($"{foundBook.Title} was rented");
            }
            else
            {
                Console.WriteLine($"A book with the specified id does not exist");
            }
           
        }

        public void ReturABook(User user)
        {
            Console.WriteLine("Please select the id of the book you want to return");
            user.Books.ForEach(x => Console.WriteLine($"{x.Id}----{x.Title}"));
            bool bookParse = int.TryParse(Console.ReadLine(), out int bookId);
            
            Book bookToReturn = user.Books.FirstOrDefault(x => x.Id == bookId);
            if(bookToReturn != null)
            {
                Console.WriteLine($"{bookToReturn.Title} was returnt");
                user.Books.Remove(bookToReturn);
            }
            else
            {
                Console.WriteLine($"A book with the specified id does not exist");
            }
        }
    }
}
