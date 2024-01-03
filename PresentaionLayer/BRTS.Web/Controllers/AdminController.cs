using Microsoft.AspNetCore.Mvc;

namespace BRTS.Web.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult AdminDashBoard()
        {
            ViewModels.AdminViewModels.DashBoardViewModel dashBoardViewModel = new ViewModels.AdminViewModels.DashBoardViewModel(); 
            
            BRTS_Providers.AccountProvider.Account _account = new BRTS_Providers.AccountProvider.Account();
            BRTS_Providers.BusesProvider.Buses _bus = new BRTS_Providers.BusesProvider.Buses();
            BRTS_Providers.TripsProvider.Trips _trip = new BRTS_Providers.TripsProvider.Trips();

            return View();
        } 
        public IActionResult CreateNewTrip()
        {
            return View();
        }
        public IActionResult CreateNewTripRequest()
        {
            return View();
        }


    }
}
