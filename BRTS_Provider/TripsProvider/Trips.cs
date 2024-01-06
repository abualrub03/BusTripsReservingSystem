using Microsoft.Data.SqlClient;
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

        public bool AddNewTrip(Entities.Trips trip , int BusId)
        {
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                    new SqlParameter{ ParameterName = "@TripName", Value =  trip.TripName },
                    new SqlParameter{ ParameterName = "@TripDestination", Value =  trip.TripDestination},
                    new SqlParameter{ ParameterName = "@TripGoingFrom", Value =  trip.TripGoingFrom },
                    new SqlParameter{ ParameterName = "@StartDateAndTime", Value =  trip.StartDateAndTime},
                    new SqlParameter{ ParameterName = "@EndDateAndTime", Value =  trip.EndDateAndTime},
                    new SqlParameter{ ParameterName = "@BusId", Value =  BusId},


                };
                return DAL.ExecuteNonQuery("spAddNewTrip");
            }
        }
    }

    
}
