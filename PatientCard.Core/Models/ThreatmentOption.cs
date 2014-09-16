using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class ThreatmentOption : IEntity<int>
	{
		[DataMember(Name = "id")]
		public virtual int Key { get; set; }

		[DataMember(Name = "name")]
		public virtual string Name { get; set; }

		[DataMember(Name = "group")]
		public virtual int? GroupNumber { get; set; }

		[DataMember(Name = "order")]
		public virtual int? OrderNumber { get; set; }
	}
}