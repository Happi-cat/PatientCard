using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class User : IEntity
	{
		public virtual string Key { get { return Username; } }

		[DataMember(Name = "username")]
		public virtual string Username { get; set; }

		public virtual string Password { get; set; }

		[DataMember(Name = "firstName")]
		public virtual string FirstName { get; set; }

		[DataMember(Name = "middleName")]
		public virtual string MiddleName { get; set; }

		[DataMember(Name = "lastName")]
		public virtual string LastName { get; set; }

		[DataMember(Name = "email")]
		public virtual string Email { get; set; }

		[DataMember(Name = "job")]
		public virtual string Job { get; set; }

		[DataMember(Name = "created")]
		public virtual DateTime? Created { get; set; }

		[DataMember(Name ="active")]
		public virtual bool Active { get; set; }

		[DataMember(Name = "address")]
		public virtual string Address { get; set; }

		[DataMember(Name = "phone")]
		public virtual string Phone { get; set; }
	}
}