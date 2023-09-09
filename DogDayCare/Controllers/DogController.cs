using Microsoft.AspNetCore.Mvc;

namespace DogDayCare.Controllers;

public class DogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
