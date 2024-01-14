using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Data;
using Ksiegarnia.Models;
using System.Collections.Generic;
using System.Linq;

namespace Ksiegarnia.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }

        public IActionResult Details(int userId)
        {
            var user = _userManager.FindByIdAsync(userId.ToString()).Result;
            return View(user);
        }

        public IActionResult Edit(int userId)
        {
            var user = _userManager.FindByIdAsync(userId.ToString()).Result;
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            // Logika edycji użytkownika
            return RedirectToAction("Index");
        }

        public IActionResult ManageRoles(int userId)
        {
            var user = _userManager.FindByIdAsync(userId.ToString()).Result;
            var roles = _roleManager.Roles.ToList();
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ManageUserRolesViewModel
            {
                UserId = userId,
                UserName = user.UserName,
                Roles = roles,
                UserRoles = userRoles.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ManageRoles(ManageUserRolesViewModel model)
        {
            // Logika zarządzania rolami użytkownika
            return RedirectToAction("Index");
        }
    }
}
