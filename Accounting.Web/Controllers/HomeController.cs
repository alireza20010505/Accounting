using Microsoft.AspNetCore.Mvc;

namespace Accounting.Web.Controllers;

public class HomeController : BaseController
{

    public IActionResult Index()
    {
        return View();
    }
}