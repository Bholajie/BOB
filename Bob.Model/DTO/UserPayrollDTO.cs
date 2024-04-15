using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.DTO
{
    public class UserPayrollDTO
    {
		public DateTime? EffectiveDate { get; set; }
        public int? BaseSalary { get; set; }
        public string? SalaryPayPeriod { get; set; }
        public string? SalaryPayFrequency { get; set; }
    }
}
