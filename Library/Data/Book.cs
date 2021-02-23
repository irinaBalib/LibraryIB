using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class Book
    {
        //Book(title, year, author, copies)
        public string Title { get; set; }

        public int Year { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }


        public Book(string title, int year, string author, int copies)
        {
            Title = title;
            Year = year;
            Author = author;
            Copies = copies;
        }

        public Book()
        {
            Copies = 1;
        }
    }
}
