using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class LibraryBooks
    {
        public List<Book> Books { get; set; }

        //  predefined items
        //title, year, author, copies
        public LibraryBooks()
        {
            Books = new List<Book>();
            Books.Add(new Book("PC", 1999, "John Gates", 1));
            Books.Add(new Book("Pants", 2020, "Julie Styles", 2));
            Books.Add(new Book("Car", 1978, "Thomas Ford", 3));
            Books.Add(new Book("Mobile", 2010, "Tim Jobs", 5));
            Books.Add(new Book("TV", 1980, "Larry King", 4));
            Books.Add(new Book("Glasses", 1995, "Ray Ban", 2));
            
        }
    }
}
