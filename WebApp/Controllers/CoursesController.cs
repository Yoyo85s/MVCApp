using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class CoursesController : Controller
{
    public IActionResult Courses()
    {
        return View();
    }
}
