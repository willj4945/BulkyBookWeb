using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers;

public class CategoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}