using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartersWebAPI.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public long Mobile { get; set; }
    }
}
