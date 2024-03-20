using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Profile";
            return View();
        }
        public ActionResult SignIn() 
        {
            ViewData["Title"] = "Sign In";
            return View();
        }
        public ActionResult SignUp()
        {
            ViewData["Title"] = "Sign Up";
            return View();
        }
        public new ActionResult SignOut()
        {
            return RedirectToAction ("Index", "Home");
        }

    }
}
