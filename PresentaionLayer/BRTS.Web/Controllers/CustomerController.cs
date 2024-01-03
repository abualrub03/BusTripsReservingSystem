using Microsoft.AspNetCore.Mvc;

namespace BRTS.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDashBoard()
        {
            return View();
        }
    }
}
