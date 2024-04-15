using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.DTO
{
    public class UserContactDTO
    {
		public string? PersonalEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int? PassportNumber { get; set; }
        public int? NationalId { get; set; }
        public int? SSN { get; set; }
        public int? TaxIdNumber { get; set; }


    }
}
