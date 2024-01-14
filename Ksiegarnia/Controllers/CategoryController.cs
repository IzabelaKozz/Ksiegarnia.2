using Ksiegarnia.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ksiegarnia.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public CategoryController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            // Logika wyświetlania kategorii
            return View();
        }

        public IActionResult BooksByCategory(int categoryId)
        {
            // Logika wyświetlania książek dla konkretnej kategorii
            return View();
        }

        // Dodaj akcje do dodawania, aktualizowania i usuwania kategorii
    }
}

