using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRTS_Providers.BookedRequestsProvider
{
    public class BookedRequests : CoreLayer.Disposable
    {
        public bool addNewBookigRequest(int tripId,int accountId)
        {
            using (var DAL = new DataAccess.DataAccessLayer())
            {
                DAL.Parameters = new List<SqlParameter> {
                    new SqlParameter{ ParameterName = "@tripId", Value =  tripId },
                    new SqlParameter{ ParameterName = "@accountId", Value =  accountId},
                    
                };
                return DAL.ExecuteNonQuery("spInsertIntoBookedRequests");
            }
        }
    }
}
