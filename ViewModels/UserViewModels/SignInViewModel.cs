using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.UserViewModels
{
    public class SignInViewModel
    {
       
        public int accountId { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? role { get; set;}
        public string? userName { get; set; }
    }
    
}
