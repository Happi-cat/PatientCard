using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class VisitDiary : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual Patient Patient { get; set; }

		[DataMember]
		[Required]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }

		[DataMember]
		[Required]
		public virtual string Description { get; set; }
	}
}