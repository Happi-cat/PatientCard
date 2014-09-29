using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class User : IEntity
	{
		public virtual string Key { get { return Username; } }

		[DataMember]
		public virtual string Username { get; set; }

		public virtual string Password { get; set; }

		[DataMember]
		public virtual string FirstName { get; set; }

		[DataMember]
		public virtual string MiddleName { get; set; }

		[DataMember]
		public virtual string LastName { get; set; }

		[DataMember]
		public virtual string Email { get; set; }

		[DataMember]
		public virtual string Job { get; set; }

		[DataMember]
		public virtual DateTime? Created { get; set; }

		[DataMember]
		public virtual bool Active { get; set; }

		[DataMember]
		public virtual string Address { get; set; }

		[DataMember]
		public virtual string Phone { get; set; }
	}
}