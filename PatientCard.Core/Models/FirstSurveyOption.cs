using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class FirstSurveyOption : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; set; }

		[DataMember(Name = "Value")]
		public virtual string Name { get; set; }

	}
}