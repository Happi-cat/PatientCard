using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class ThreatmentPlan : IEntity<Tuple<int, int>>
	{
		public virtual Tuple<int, int> Key { get { return new Tuple<int, int>(PatientId, ThreatmentOptionId); } }

		[DataMember]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual Patient Patient { get; set; }

		[DataMember]
		public virtual int ThreatmentOptionId { get; set; }

		[DataMember]
		public virtual ThreatmentOption ThreatmentOption { get; set; }

		[DataMember]
		[Required]
		public virtual string Description { get; set; }

		[DataMember]
		[Required]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }

		[DataMember]
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