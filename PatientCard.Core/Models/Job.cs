using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class Job : IEntity
	{
		public virtual string Key { get { return Name; } }

		[DataMember(Name = "Job")]
		public virtual string Name { get; set; }

		[DataMember(Name = "Description")]
		public virtual string Description { get; set; }
	}
}