using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob.Model.Entities
{
	public class ApplicationUser : IdentityUser
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid OrganizationId { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime ModificationDate { get; set; }
	}
}
