using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class Job : IEntity
	{
		public virtual string Key { get { return Name; } }

		[DataMember(Name = "job")]
		public virtual string Name { get; set; }

		[DataMember(Name = "description")]
		public virtual string Description { get; set; }
	}
}