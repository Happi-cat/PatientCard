using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class FirstSurvey :IEntity<int>
	{
		public virtual int Key { get { return PatientId; } }

		[DataMember]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual string Reason { get; set; }

		[DataMember]
		public virtual string Face { get; set; }

		[DataMember]
		public virtual string Skin { get; set; }

		[DataMember]
		public virtual string Limbs { get; set; }

		[DataMember]
		public virtual string Bones { get; set; }

		[DataMember]
		public virtual IList<FirstSurveyDetail> Details { get; set; }
	}
}