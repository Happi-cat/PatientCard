using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class Patient : IEntity<int>
	{
		[DataMember(Name = "id")]
		public virtual int Key { get; set; }

		[DataMember(Name = "firstName")]
		public virtual string FirstName { get; set; }

		[DataMember(Name = "middleName")]
		public virtual string MiddleName { get; set; }

		[DataMember(Name = "lastName")]
		public virtual string LastName { get; set; }

		[DataMember(Name = "birthday")]
		public virtual DateTime? BirthDate { get; set; }

		[DataMember(Name = "gender")]
		public virtual Gender Gender { get; set; }
		
		[DataMember(Name = "address")]
		public virtual string Address { get; set; }

		[DataMember(Name = "phone")]
		public virtual string Phone { get; set; }

		[DataMember(Name = "social")]
		public virtual string SocialStatus { get; set; }

		[DataMember(Name = "job")]
		public virtual string Job { get; set; }

		[DataMember(Name = "created")]
		public virtual DateTime Created { get; set; }
	}
}