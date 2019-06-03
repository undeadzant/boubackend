using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boubackend.Models
{
    public class Vendors
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAddress { get; set; }
        public string WebAddress { get; set; }
        public string FacebookPage { get; set; }
        public string InstagramPage { get; set; }
        public string VendorBio { get; set; }
    }
}
