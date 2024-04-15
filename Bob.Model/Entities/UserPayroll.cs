using Bob.Model.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.Entities
{
	public class UserPayroll: BaseEntity
	{
		public DateTime? EffectiveDate { get; set; }
		public int? BaseSalary { get; set; }
		public string? SalaryPayPeriod { get; set; }
		public string? SalaryPayFrequency { get; set; }
		[ForeignKey("UserId")]
		[ValidateNever]
		public User User { get; set; }
	}
}
