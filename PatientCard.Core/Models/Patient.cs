using System;

namespace PatientCard.Core.Models
{
	public class Patient : IEntity<int>
	{
		public virtual int Key { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string MiddleName { get; set; }

		public virtual string LastName { get; set; }

		public virtual DateTime BirthDate { get; set; }

		public virtual Gender Gender { get; set; }
		
		public virtual string Address { get; set; }

		public virtual string Phone { get; set; }

		public virtual string SocialStatus { get; set; }

		public virtual string Work { get; set; }

		public virtual DateTime Created { get; set; }
	}
}