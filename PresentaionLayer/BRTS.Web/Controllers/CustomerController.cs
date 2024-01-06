using Microsoft.AspNetCore.Mvc;
using ViewModels.AdminViewModels;

namespace BRTS.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerDashBoard()
        {
              var dataFromPreviousAction = (int)TempData["Id"];
            return View(  new DashBoardViewModel( new BRTS_Providers.TripsProvider.Trips().getAllTrips(), dataFromPreviousAction) );
        }
        [HttpPost]
        public IActionResult BookAtrip(int id, int TripId)
        {
            //
            new BRTS_Providers.BookedRequestsProvider.BookedRequests().addNewBookigRequest(tripId:TripId ,id);


            //
            return View("CustomerDashBoard", new DashBoardViewModel(new BRTS_Providers.TripsProvider.Trips().getAllTrips(), id));
        }
    }
}
