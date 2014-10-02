using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class CpiStatus : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual int? Value1 { get; set; }

		[DataMember]
		public virtual int? Value2 { get; set; }

		[DataMember]
		public virtual int? Value3 { get; set; }

		[DataMember]
		public virtual int? Value4 { get; set; }

		[DataMember]
		public virtual int? Value5 { get; set; }

		[DataMember]
		public virtual int? Value6 { get; set; }

		[DataMember]
		public virtual float Cpi { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		[DataMember]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }
	}
}