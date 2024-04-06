using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;
using System.Security.Principal;
using System;
using WebApp.ViewModels;
using static System.Collections.Specialized.BitVector32;
using Microsoft.Extensions.Options;
using System.Threading.Channels;
using System.Xml.Linq;
using System.Reflection;

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
            return RedirectToAction("Index", "Home");
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
                return View(viewModel);

            //var result = _accountService.SignIn(viewModel.Form);
            //if (result)
            //    return RedirectToAction("Account", "Index");

            viewModel.ErrorMessage = "Incorrect email or password";
                return View(viewModel);

            
        }



        //private readonly AccountService _AccountService;

        //public AccountController(AccountService accountService)
        //{
        //    _AccountService = accountService;
        //}

        [Route("/Details")]
        public IActionResult Details()
        {
            var viewModel = new AccountDetailsViewModel();
            //viewModel.BasicInfo = _accontService.GetBasicInfo();
            //viewModel.AddressInfo= _accountService.GetAddressInfo();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
        {
            //_accountService.SaveBasicInfo(viewModel.BasicInfo);
            return RedirectToAction(nameof(Details), viewModel); 
        }

        [HttpPost]
        public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
        {
            //_accountService.SaveBasicInfo(viewModel.BasicInfo);
            return RedirectToAction(nameof(Details), viewModel);
        }
    }
}







