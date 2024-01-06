using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class BookedRequests
    {
        public int BookedRequestsId {  get; set; }
        public int TripId { get; set; }
        public int accountId { get; set; }

    }
}
