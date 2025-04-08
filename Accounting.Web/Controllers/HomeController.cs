using Microsoft.AspNetCore.Mvc;

namespace Accounting.Web.Controllers;

public class HomeController : BaseController
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}