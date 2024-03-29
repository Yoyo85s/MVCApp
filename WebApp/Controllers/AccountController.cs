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
        
        [Route("/signup")]
        [HttpGet]
        public ActionResult SignUp()
        {
            var viewModel = new SignUpViewModel();
            return View(viewModel);
        }

        [Route("/signup")]
        [HttpPost]
        public ActionResult SignUp(SignUpViewModel viewModel)
        {
            if (!ModelState.IsValid) 
            return View(viewModel);

            return RedirectToAction("SignIn", "Account");
        }
        public new ActionResult SignOut()
        {
            return RedirectToAction ("Index", "Home");
        }

        [Route("/signin")]
        [HttpGet]
        public ActionResult SignIn()
        {
            var viewModel = new SignInViewModel();
            return View(viewModel);
        }

        [Route("/signin")]
        [HttpPost]
        public ActionResult SignIn(SignInViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.ErrorMessage = "Incorrect email or password"; 
                return View(viewModel);
            }
                

            return RedirectToAction("Account", "Index");
        }

    }
}
