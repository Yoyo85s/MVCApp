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
        [HttpGet]
        public ActionResult SignUp()
        {
            var viewmodel = new SignUpViewModel();
            return View(viewmodel);
        }

        [Route("/signup")]
        [HttpPost]
        public ActionResult SignUp(SignUpViewModel viemodel)
        {
            if (!ModelState.IsValid) 
            return View(viemodel);

            return RedirectToAction("SignIn", "Account");
        }
        public new ActionResult SignOut()
        {
            return RedirectToAction ("Index", "Home");
        }

    }
}
