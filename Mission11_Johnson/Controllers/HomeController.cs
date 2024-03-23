using Microsoft.AspNetCore.Mvc;
using Mission11_Johnson.Models;
using System.Diagnostics;

namespace Mission11_Johnson.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
