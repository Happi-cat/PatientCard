using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class VisitDiary : IEntity<int>
	{
		[DataMember(Name = "id")]
		public virtual int Key { get; set; }

		[DataMember(Name = "patientId")]
		public virtual int PatientId { get; set; }

		[DataMember(Name = "username")]
		public virtual string Username { get; set; }

		[DataMember(Name = "description")]
		public virtual string Description { get; set; }
	}
}