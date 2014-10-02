using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	public class DentistStatus : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; private set; }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual string Bite { get; set; }

		[DataMember]
		public virtual string HardTissue { get; set; }

		[DataMember]
		public virtual string Mucous { get; set; }

		[DataMember]
		public virtual string XrayDiagnostics { get; set; }

		[DataMember]
		public virtual string PreliminaryDiagnosis { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		[DataMember]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }
	}
}