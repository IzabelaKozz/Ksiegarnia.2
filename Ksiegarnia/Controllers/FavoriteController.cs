using Ksiegarnia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Ksiegarnia.Controllers
{
    [Authorize]
    public class FavoriteController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IBookRepository _bookRepository;

        public FavoriteController(UserManager<User> userManager, IBookRepository bookRepository)
        {
            _userManager = userManager;
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            var user = _userManager.GetUserAsync(User).Result;
            var favoriteBooks = _bookRepository.GetFavoriteBooks(user.UserId);
            return View(favoriteBooks);
        }

        public IActionResult AddToFavorites(int bookId)
        {
            var user = _userManager.GetUserAsync(User).Result;
            var book = _bookRepository.GetBookById(bookId);

            if (book != null)
            {
                // Dodaj książkę do ulubionych użytkownika
                _bookRepository.AddToFavorite(user.UserId, bookId);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromFavorites(int bookId)
        {
            var user = _userManager.GetUserAsync(User).Result;
            var book = _bookRepository.GetBookById(bookId);

            if (book != null)
            {
                // Usuń książkę z ulubionych użytkownika
                _bookRepository.RemoveFromFavorite(user.UserId, bookId);
            }

            return RedirectToAction("Index");
        }
    }
}
