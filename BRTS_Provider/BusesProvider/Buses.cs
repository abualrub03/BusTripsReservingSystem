using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRTS_Providers.BusesProvider
{
    public class Buses : CoreLayer.Disposable
    {
        public List<Entities.Buses> getAllBuses()
        {
            using var DAL = new DataAccess.DataAccessLayer();
            return DAL.ExecuteReader<Entities.Buses>("spSelectAllTblBuses");
        }

        public bool AddNewBuss(Entities.Buses bus)
        {
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                    new SqlParameter{ ParameterName = "@tripId", Value =  bus.TripId },
                    new SqlParameter{ ParameterName = "@Captin_Id", Value =  bus.Captin_Id},
                    new SqlParameter{ ParameterName = "@TotalSeats", Value =  bus.TotalSeats },
                    new SqlParameter{ ParameterName = "@AvailabelSeats", Value =  bus.AvailabelSeats},
                };
                return DAL.ExecuteNonQuery("spAddNewBus");
            }
        }

    }
}
