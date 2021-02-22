using System;
using Library.Logic;


namespace Library.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();

            System.Console.WriteLine("Welcome to the Library!");
            var books = manager.GetAvailableBooks();
            if(books.Count == 0)
            {
                System.Console.WriteLine("There are no available copies at the moment!");
            }
            else
            {
                //foreach (var book in books)
                //{
                //    System.Console.WriteLine("{0} by {1}, {2}, {3} copies", book.Title, book.Author, book.Year, book.Copies);
                //}
                books.ForEach(book =>
                {
                    System.Console.WriteLine("{0} by {1}, {2}, {3} copies", book.Title, book.Author, book.Year, book.Copies);
                });
            }

            while (true)
            {
               System.Console.Write("Enter book's title: ");
                string input = System.Console.ReadLine();
                if (input == "stop")
                {
                    // stop the  process
                    break;
                }

                var bookTaken = manager.TakeBook(input);
                if (bookTaken == null)
                {
                    System.Console.WriteLine("Book is not available!");
                }
                else
                {
                    System.Console.WriteLine("Book {0} added to your list!", bookTaken.Title);
                }
            }

            System.Console.WriteLine("Your books: ");

            var myBooks = manager.GetUserBooks();
            if (myBooks.Count == 0)
            {
                System.Console.WriteLine("You haven't taken any books!");
            }
            else
            {
                myBooks.ForEach(book =>
                {
                    System.Console.WriteLine("{0} ({1}) {2}", book.Title, book.Author, book.Year);
                });
            }

           

        }
    }
}
