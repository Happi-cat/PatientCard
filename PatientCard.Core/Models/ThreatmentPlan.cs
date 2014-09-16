using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class ThreatmentPlan : IEntity<Tuple<int, int>>
	{
		public virtual Tuple<int, int> Key { get { return new Tuple<int, int>(PatientId, ThreatmentOptionId); } }

		[DataMember(Name = "patientId")]
		public virtual int PatientId { get; set; }

		[DataMember(Name = "threatmentOptionId")]
		public virtual int ThreatmentOptionId { get; set; }

		[DataMember(Name = "description")]
		public virtual string Description { get; set; }

		[DataMember(Name = "username")]
		public virtual string Username { get; set; }

		[DataMember(Name = "created")]
		public virtual DateTime Created { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as ThreatmentPlan;

			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return this.PatientId == other.PatientId &&
				this.ThreatmentOptionId == other.ThreatmentOptionId;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = GetType().GetHashCode();
				hash = (hash * 31) ^ PatientId.GetHashCode();
				hash = (hash * 31) ^ ThreatmentOptionId.GetHashCode();

				return hash;
			}
		}
	}
}