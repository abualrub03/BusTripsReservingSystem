using Microsoft.AspNetCore.Mvc;

namespace BRTS.Web.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult AdminDashBoard()
        {
           return View(new ViewModels.AdminViewModels.DashBoardViewModel(new BRTS_Providers.AccountProvider.Account().getAllAccounts(), new BRTS_Providers.BusesProvider.Buses().getAllBuses(), new BRTS_Providers.TripsProvider.Trips().getAllTrips()));
        }    
        public IActionResult CreateTrip()
        {
            return View(new BRTS_Providers.BusesProvider.Buses().getAllBuses());
        }
        public IActionResult CreateNewTripRequest()
        {
            return View();
        }
        public IActionResult AddNewBus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewBusRequest(Entities.Buses bus)
        {
            return View( "AddNewBus",new BRTS_Providers.BusesProvider.Buses().AddNewBuss(bus));
        } 
        [HttpPost]
        public IActionResult AddNewTripRequest(Entities.Trips trip , int BusId)
        {
            new BRTS_Providers.TripsProvider.Trips().AddNewTrip(trip, BusId);
            return View( "CreateTrip",new BRTS_Providers.BusesProvider.Buses().getAllBuses());    
                
        }
       


    }
}
