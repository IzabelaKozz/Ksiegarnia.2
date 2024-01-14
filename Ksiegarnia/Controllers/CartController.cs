using Ksiegarnia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace Ksiegarnia.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public CartController(IBookRepository bookRepository, UserManager<IdentityUser> userManager)
        {
            _bookRepository = bookRepository;
            _userManager = userManager;
        }
        [Authorize]
        public IActionResult Index()
        {
            // Get the currently logged-in user
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            // Check if the user exists and has an ID
            if (user != null && !string.IsNullOrEmpty(user.Id))
            {
                // Use the user's ID to retrieve the cart
                var cart = HttpContext.Session.GetString($"Cart_{user.Id}");
                var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

                return View(cartModel);
            }
            else
            {
                // Handle the case where the user is not found or doesn't have an ID
                // You can redirect to an error page or display an appropriate message
                return RedirectToAction("Error");
            }
        }


        [Authorize]
        public IActionResult AddToCart(int bookId, int quantity)
        {
            // Get the currently logged-in user
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            // Check if the user exists and has an ID
            if (user != null && !string.IsNullOrEmpty(user.Id))
            {
                var book = _bookRepository.GetBookById(bookId);

                var cart = HttpContext.Session.GetString($"Cart_{user.Id}");
                var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

                var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

                if (cartItem == null)
                {
                    cartModel.Items.Add(new CartItem
                    {
                        BookId = book.BookId,
                        Title = book.Title,
                        Quantity = quantity,
                        Price = book.Price
                    });
                }
                else
                {
                    cartItem.Quantity += quantity;
                }

                HttpContext.Session.SetString($"Cart_{user.Id}", JsonConvert.SerializeObject(cartModel));

                return RedirectToAction("Index");
            }
            else
            {
                // Handle the case where the user is not found or doesn't have an ID
                // You can redirect to an error page or display an appropriate message
                return RedirectToAction("Error");
            }
        }
        [HttpPost]
        public IActionResult UpdateQuantity(int bookId, int quantity)
        {
            if (quantity < 1)
            {
                TempData["ErrorMessage"] = "Ilość książek musi być większa niż 0.";
                return RedirectToAction("Index");
            }

            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            if (user != null && !string.IsNullOrEmpty(user.Id))
            {
                var cart = HttpContext.Session.GetString($"Cart_{user.Id}");
                var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

                var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

                if (cartItem != null)
                {
                    cartItem.Quantity = quantity;
                }

                HttpContext.Session.SetString($"Cart_{user.Id}", JsonConvert.SerializeObject(cartModel));

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        public IActionResult RemoveFromCart(int bookId)
        {
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            if (user != null && !string.IsNullOrEmpty(user.Id))
            {
                var cart = HttpContext.Session.GetString($"Cart_{user.Id}");
                var cartModel = string.IsNullOrEmpty(cart) ? new Cart() : JsonConvert.DeserializeObject<Cart>(cart);

                var cartItem = cartModel.Items.FirstOrDefault(item => item.BookId == bookId);

                if (cartItem != null)
                {
                    cartModel.Items.Remove(cartItem);
                }

                HttpContext.Session.SetString($"Cart_{user.Id}", JsonConvert.SerializeObject(cartModel));

                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }




        // Inne metody kontrolera
    }
}
