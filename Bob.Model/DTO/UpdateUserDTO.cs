using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.DTO
{
	public class UpdateUserDTO
	{
		public string? FirstName { get; set; }
		[MaxLength(50)]
		public string? Surname { get; set; }
		[MaxLength(100)]
		public string? FullName { get => $"{FirstName} {Surname}"; }
		public string? DispalyName { get; set; }
		public string? MiddleName { get; set; }

		public string? Email { get; set; }
		public string? Prefix { get; set; }
		public string? Pronouns { get; set; }

		public DateOnly? DateOfBirth { get; set; }

		public string? Nationality1 { get; set; }
		public string? Nationality2 { get; set; }

		public string? Language1 { get; set; }
		public string? Language2 { get; set; }
	}
}
