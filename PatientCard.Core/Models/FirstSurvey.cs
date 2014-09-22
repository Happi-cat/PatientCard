using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class FirstSurvey :IEntity<int>
	{
		public virtual int Key { get { return PatientId; } }

		[DataMember(Name = "patientId")]
		public virtual int PatientId { get; set; }

		[DataMember(Name = "reason")]
		public virtual string Reason { get; set; }

		[DataMember(Name = "face")]
		public virtual string Face { get; set; }

		[DataMember(Name = "skin")]
		public virtual string Skin { get; set; }

		[DataMember(Name = "limbs")]
		public virtual string Limbs { get; set; }

		[DataMember(Name = "bones")]
		public virtual string Bones { get; set; }

		[DataMember(Name = "details")]
		public virtual IList<FirstSurveyDetail> Details { get; set; }
	}
}