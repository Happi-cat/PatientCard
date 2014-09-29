using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class Patient : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember]
		public virtual string FirstName { get; set; }

		[DataMember]
		public virtual string MiddleName { get; set; }

		[DataMember]
		public virtual string LastName { get; set; }

		[DataMember]
		public virtual DateTime? Birthday { get; set; }

		[DataMember]
		[JsonConverter(typeof(StringEnumConverter))]
		public virtual Gender Gender { get; set; }
		
		[DataMember]
		public virtual string Address { get; set; }

		[DataMember]
		public virtual string Phone { get; set; }

		[DataMember]
		public virtual string SocialStatus { get; set; }

		[DataMember]
		public virtual string Job { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }
	}
}