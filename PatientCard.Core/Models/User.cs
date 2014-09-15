using System;

namespace PatientCard.Core.Models
{
	public class User : IEntity
	{
		public virtual string Key { get { return Username; } }

		public virtual string Username { get; set; }

		public virtual string Password { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string MiddleName { get; set; }

		public virtual string LastName { get; set; }

		public virtual string Email { get; set; }

		public virtual string Job { get; set; }

		public virtual DateTime Created { get; set; }
	}
}