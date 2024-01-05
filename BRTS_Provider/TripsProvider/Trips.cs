using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRTS_Providers.TripsProvider
{
    public class Trips : CoreLayer.Disposable 
    {
        public List<Entities.Trips> getAllTrips()
        {
            using var DAL = new DataAccess.DataAccessLayer();
            return DAL.ExecuteReader<Entities.Trips>("spSelectAllTblTrips");
        }
    }
}
