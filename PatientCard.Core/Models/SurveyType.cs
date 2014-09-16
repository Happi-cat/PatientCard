using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class SurveyType : IEntity<int>
	{
		[DataMember(Name = "id")]
		public virtual int Key { get; set; }

		[DataMember(Name = "value")]
		public virtual string Name { get; set; }

	}
}