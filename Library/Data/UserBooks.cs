using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Data
{
    public class UserBooks
    {
        public List<Book> Books { get; set; }

        public UserBooks()
        {
            Books = new List<Book>();
        }

       
    }
}
