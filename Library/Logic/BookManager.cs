using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data;

namespace Library.Logic
{
    public class BookManager
    {
        /*  
         ------ GetAvailableBooks() - returns list of all available books
        ------ GetUserBooks() - returns list of user's books
        ------ TakeBook(string title) - gives the book to the user
        ------ ReturnBook(string title) - returns the book back to the library
        */
        private UserBooks User { get; set; }
        private LibraryBooks Library { get; set; }

        public BookManager()
        {
            User = new UserBooks();
            Library = new LibraryBooks();
        }

        public List<Book> GetAvailableBooks()
        {
            return Library.Books.Where(b => b.Copies > 0).OrderBy(b => b.Title).ToList();
        }
        public List<Book> GetUserBooks()
        {
            return User.Books.ToList();
        }
        public Book TakeBook(string title)
        {
            // Take - user takes a book providing its title. Validation if book exists. Validation if book is
            // still available(check number of copies). Book is added to the user's list and available
            // book count is decreased.

            var book = Library.Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null && book.Copies > 0)
            {
                book.Copies--;
                User.Books.Add(book);

                return book;
            }

            return null;
        }
        public Book ReturnBook(string title)
        {
            var userBook = User.Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (userBook != null)
            {
                User.Books.Remove(userBook);
                // increase available copies
                var libraryBook = Library.Books.Find(b => b.Title == userBook.Title);
                libraryBook.Copies++;

                return userBook;
            }

            return null;
        }

        

    }

}
