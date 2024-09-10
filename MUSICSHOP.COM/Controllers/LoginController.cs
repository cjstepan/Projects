using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicShop.com.Data;
using MusicShop.com.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MusicShop.com.Controllers
{
    public class LoginController : Controller
    {
        private readonly MusicShopcomContext _context;

        public LoginController(MusicShopcomContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                // Check if the provided username and password exist in the User table
                var loginUser = await _context.User
                    .FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);

                if (loginUser != null)
                {
                    // Check UserType and redirect accordingly
                    if (loginUser.UserType == "admin")
                    {
                        // Redirect to the Music page for Admin
                        return RedirectToAction("Index", "Musics");
                    }
                    else if (loginUser.UserType == "member")
                    {
                        // Redirect to the Shop page for Member
                        return RedirectToAction("Index", "BrowseMusic");
                    }
                }

                // Authentication failed, show an error message
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return View("Index", user);
            }

            // If the model state is not valid, return to the login page with validation errors
            return View("Index", user);
        }

    }
}
