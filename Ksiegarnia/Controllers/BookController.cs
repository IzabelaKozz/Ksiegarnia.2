using Ksiegarnia.Data;
using Ksiegarnia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ksiegarnia.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        
        public IActionResult Index()
        {
            var books = _bookRepository.GetAllBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepository.GetBookById(id);
            return View(book);
        }
    }
}
