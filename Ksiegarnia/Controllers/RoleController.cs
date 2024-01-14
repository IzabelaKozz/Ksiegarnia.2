using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Models;
using Ksiegarnia.Data;

namespace Ksiegarnia.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdentityRole role)
        {
            // Logika tworzenia nowej roli
            return RedirectToAction("Index");
        }

        public IActionResult Edit(string roleId)
        {
            var role = _roleManager.FindByIdAsync(roleId).Result;
            return View(role);
        }

        [HttpPost]
        public IActionResult Edit(IdentityRole role)
        {
            // Logika edycji roli
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string roleId)
        {
            var role = _roleManager.FindByIdAsync(roleId).Result;
            return View(role);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string roleId)
        {
            // Logika usuwania roli
            return RedirectToAction("Index");
        }
    }
}
