using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonSys.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
    }
}
