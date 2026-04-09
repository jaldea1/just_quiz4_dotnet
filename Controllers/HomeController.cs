using System.Diagnostics;
using just_quiz4_dotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace just_quiz4_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Database access has aleady been done by Justine Aldea.";
            return View();
        }
        
    }
}
