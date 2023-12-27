using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace BRTS.Web.Controllers
{
    public class UserController : Controller
    {
        [Route("")]  
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Events()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult EventDetails()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Elements()
        {
            return View();
        }
    }
}
