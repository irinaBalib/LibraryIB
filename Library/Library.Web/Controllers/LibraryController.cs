using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Logic;
using Library.Data;


namespace Library.Web.Controllers
{
    public class LibraryController : Controller
    {
        private static BookManager manager = new BookManager();
        public IActionResult Index()
        {
            var books = manager.GetAvailableBooks();
            return View(books);
        }

        //for viewing user's list 
        public IActionResult UserBooks()
        {
            var books = manager.GetUserBooks();
            return View(books);
        }

        public IActionResult Take(string title)
        {
            manager.TakeBook(title);
           return RedirectToAction(nameof(UserBooks));
        }

    }
}
