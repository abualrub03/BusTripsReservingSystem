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
        public IActionResult CheckingStatusRequest(Entities.Account account)
        {
            BRTS_Providers.AccountProvider.Account _account = new BRTS_Providers.AccountProvider.Account();
            var statusViewModel = _account.StatusChecking(account);
            return View("CheckingStatus");
        }
       
        [HttpPost]
        public IActionResult SignUpRequest(IFormFile imageFile, Entities.Account Account)
        {
            BRTS_Providers.AccountProvider.Account _account = new BRTS_Providers.AccountProvider.Account();
            _account.SignUpNewAccount(imageFile, Account);

            return SignIn();
        }
        [HttpPost]
        public IActionResult SignInRequest( Entities.Account Account)
        {
            BRTS_Providers.AccountProvider.Account _account = new BRTS_Providers.AccountProvider.Account();
            var account = _account.SignInRequest(Account);
            if(account.role == "Admin")
            {
                return RedirectToAction( "AdminDashBoard", "Admin");
            }
            else if (account.role == "Captin")
            {
                return RedirectToAction( "CaptinDashBoard", "Captin");
            }
            else
            {
                TempData["Id"] = account.accountId;

                return RedirectToAction( "CustomerDashBoard", "Customer");
            }
        }
    }
}
