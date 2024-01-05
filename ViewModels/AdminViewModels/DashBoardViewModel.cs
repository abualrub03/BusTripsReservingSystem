using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.AdminViewModels
{
    public class DashBoardViewModel
    {
        public DashBoardViewModel(List<Entities.Account> _accounts , List<Entities.Buses> _buses ,List<Entities.Trips> _trips ) { 
            accounts = _accounts ;
            buses = _buses ;
            trips = _trips ;
        }
        public List<Entities.Account> accounts { get; set; }
        public List<Entities.Buses> buses { get; set; }
        public List<Entities.Trips> trips { get; set; }



    }
}
