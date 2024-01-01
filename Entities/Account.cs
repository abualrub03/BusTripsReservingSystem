using System.Data;
using System.Net.NetworkInformation;

namespace Entities
{
    public class Account
    {
        public int accountId {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string role { get; set; }
        public string emailAddress { get; set; }
        public string phoneNumber { get; set; }
        public string gender { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int tripsId { get; set; }
        public string status { get; set; }
        public int imageId { get; set; }


    }
}
