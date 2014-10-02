using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class OhisStatus : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; private set; }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual int? Cis1 { get; set; }

		[DataMember]
		public virtual int? Cis2 { get; set; }

		[DataMember]
		public virtual int? Cis3 { get; set; }

		[DataMember]
		public virtual int? Cis4 { get; set; }

		[DataMember]
		public virtual int? Cis5 { get; set; }

		[DataMember]
		public virtual int? Cis6 { get; set; }

		[DataMember]
		public virtual int? Dis1 { get; set; }

		[DataMember]
		public virtual int? Dis2 { get; set; }

		[DataMember]
		public virtual int? Dis3 { get; set; }

		[DataMember]
		public virtual int? Dis4 { get; set; }

		[DataMember]
		public virtual int? Dis5 { get; set; }

		[DataMember]
		public virtual int? Dis6 { get; set; }

		[DataMember]
		public virtual float Ohis { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		[DataMember]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }
	}
}