using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class TreatmentOption : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember]
		public virtual string Name { get; set; }

		[DataMember(Name = "Group")]
		public virtual int? GroupNumber { get; set; }

		[DataMember(Name = "Order")]
		public virtual int? OrderNumber { get; set; }
	}
}