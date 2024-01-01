using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace BRTS.Web.Controllers
{
    public class UserController : Controller
    {
       
        [Route("")]
        [Route("/User/Index")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Trips()
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
        }public IActionResult SignIn()
        {
            return View("SignIn");
        }public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult CheckingStatus()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult SignUpRequest(IFormFile imageFile, Entities.Account Account)
        {

            return SignIn();
        }
    }
}
