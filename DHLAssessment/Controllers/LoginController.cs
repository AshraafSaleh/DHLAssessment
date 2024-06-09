using Microsoft.AspNetCore.Mvc;
using DHLAssessment.Models;

namespace DHLAssessment.Controllers
{
    public class LoginController : Controller
    {
        //Hardcoded credentials
        private const string HardcodedUsername = "Ashraaf";
        private const string HardcodedPassword = "Password";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.UserName == HardcodedUsername && model.Password == HardcodedPassword)
            {
                return RedirectToAction("Account");
            }
            ViewBag.ErrorMessage = "Invalid username or password";
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }
    }
}
