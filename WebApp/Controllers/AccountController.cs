using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

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

        [Route("/signup")]
        public ActionResult SignUp()
        {
            var viewmodel = new SignUpViewModel();
            //ViewData["Title"] = "Sign Up";
            return View(viewmodel);
        }
        public new ActionResult SignOut()
        {
            return RedirectToAction ("Index", "Home");
        }

    }
}
