using Microsoft.AspNetCore.Mvc;
using WebApp.Models.Sections;
using WebApp.Models.Views;

namespace WebApp.Controllers;

public class HomeController : Controller
{

    // https://domain.com/Index
    public IActionResult Index()
    {

        var viewModel = new HomeIndexViweModel
        {
            Title = "Ultimate Task Management Assistant",
            Showcase = new ShowcaseViewModel
            {
                Id = "overview",
                ShowcaseImage = new() {  ImageUrl = "/images/showcase-taskmaster.svg", AltText ="Task management Assistant" },
                Title = "Task Management Assistant You Gonna Love",
                Text= "We offer you a new generation of task management system. PLan, manage & track all your tasks in one flexible tool",
                Link = new() {  ControllerName = "Downloads", ActionName ="Index", Text= "Get started for free" },
                BrandsText = "Largest companies use our tool to work efficiently",
                Brands = 
                [
                    new() { ImageUrl = "/images/brands/brand_1.svg", AltText = "Brand Name1" },
                    new() { ImageUrl = "/images/brands/brand_2.svg", AltText = "Brand Name2" },
                    new() { ImageUrl = "/images/brands/brand_3.svg", AltText = "Brand Name3" },
                    new() { ImageUrl = "/images/brands/brand_4.svg", AltText = "Brand Name4" },
                ],
                
               


            }
        };
        ViewData["Title"] = viewModel.Title;
        return View( viewModel );
    }
}
