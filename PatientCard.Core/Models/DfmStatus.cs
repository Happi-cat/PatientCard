using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class DfmStatus : IEntity<int>
	{
		[DataMember(Name = "Id")]
		public virtual int Key { get; private set; }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual char? UpperLeft1 { get; set; }

		[DataMember]
		public virtual char? UpperLeft2 { get; set; }

		[DataMember]
		public virtual char? UpperLeft3 { get; set; }

		[DataMember]
		public virtual char? UpperLeft4 { get; set; }

		[DataMember]
		public virtual char? UpperLeft5 { get; set; }

		[DataMember]
		public virtual char? UpperLeft6 { get; set; }

		[DataMember]
		public virtual char? UpperLeft7 { get; set; }

		[DataMember]
		public virtual char? UpperLeft8 { get; set; }

		[DataMember]
		public virtual char? UpperRight1 { get; set; }

		[DataMember]
		public virtual char? UpperRight2 { get; set; }

		[DataMember]
		public virtual char? UpperRight3 { get; set; }

		[DataMember]
		public virtual char? UpperRight4 { get; set; }

		[DataMember]
		public virtual char? UpperRight5 { get; set; }

		[DataMember]
		public virtual char? UpperRight6 { get; set; }

		[DataMember]
		public virtual char? UpperRight7 { get; set; }

		[DataMember]
		public virtual char? UpperRight8 { get; set; }

		[DataMember]
		public virtual char? LowerLeft1 { get; set; }

		[DataMember]
		public virtual char? LowerLeft2 { get; set; }

		[DataMember]
		public virtual char? LowerLeft3 { get; set; }

		[DataMember]
		public virtual char? LowerLeft4 { get; set; }

		[DataMember]
		public virtual char? LowerLeft5 { get; set; }

		[DataMember]
		public virtual char? LowerLeft6 { get; set; }

		[DataMember]
		public virtual char? LowerLeft7 { get; set; }

		[DataMember]
		public virtual char? LowerLeft8 { get; set; }

		[DataMember]
		public virtual char? LowerRight1 { get; set; }

		[DataMember]
		public virtual char? LowerRight2 { get; set; }

		[DataMember]
		public virtual char? LowerRight3 { get; set; }

		[DataMember]
		public virtual char? LowerRight4 { get; set; }

		[DataMember]
		public virtual char? LowerRight5 { get; set; }

		[DataMember]
		public virtual char? LowerRight6 { get; set; }

		[DataMember]
		public virtual char? LowerRight7 { get; set; }

		[DataMember]
		public virtual char? LowerRight8 { get; set; }

		[DataMember]
		public virtual float Dfm { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		[DataMember]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }
	}
}