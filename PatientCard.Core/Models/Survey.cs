using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class Survey : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual Patient Patient { get; set; }

		[DataMember(IsRequired = true)]
		[Required]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }

		[DataMember]
		public virtual int? TypeId { get; set; }

		[DataMember]
		public virtual SurveyType Type { get; set; }

		[DataMember]
		[Required]
		public virtual string Description { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		[DataMember]
		public virtual float? Dose { get; set; }
	}
}