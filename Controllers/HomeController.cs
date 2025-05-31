using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MVC_APP.Models; // Ensure you have the correct namespace for your LoginModel

namespace MVC_APP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid) 
            {
                
                if (loginModel.Username == "1" && loginModel.Password == "1")
                {
                    return RedirectToAction("Dashboard");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(loginModel);
        }

       
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(); // Sign out the user
            return RedirectToAction("Login", "Home"); // Redirect to login page
        }

      
    }
}
