﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.DTO.UserDTO
{
	public class UserRequestDTO
	{
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }
		[Required]
		[MaxLength(50)]
		public string Surname { get; set; }
		[MaxLength(100)]
		public string? DispalyName { get; set; }
		public string? MiddleName { get; set; }
		[Required]
		public string Email { get; set; }
		[MaxLength(50)]
		public string? Prefix { get; set; }
		[MaxLength(50)]
		public string? Pronouns { get; set; }
		[Required]
		public DateOnly DateOfBirth { get; set; }
		[Required]
		[MaxLength(50)]
		public string Nationality1 { get; set; }
		[MaxLength(50)]
		public string? Nationality2 { get; set; }
		[Required]
		[MaxLength(50)]
		public string Language1 { get; set; }
		[MaxLength(50)]
		public string? Language2 { get; set; }
		[MaxLength(50)]
		public DateTime CreationDate { get; set; }
		public DateTime ModificaionDate { get; set; }
	}
}
