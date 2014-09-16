using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public enum Gender
	{
		[EnumMember(Value = "unspecified")]
		Unspecified,
		[EnumMember(Value = "male")]
		Male, 
		[EnumMember(Value = "female")]
		Female,
	}
}