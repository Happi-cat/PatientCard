using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class TreatmentPlan : IEntity<Tuple<int, int>>
	{
		public virtual Tuple<int, int> Key { get { return new Tuple<int, int>(PatientId, TreatmentOptionId); } }

		[DataMember(IsRequired = true)]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual Patient Patient { get; set; }

		[DataMember]
		public virtual int TreatmentOptionId { get; set; }

		[DataMember]
		public virtual TreatmentOption TreatmentOption { get; set; }

		[DataMember]
		public virtual string Description { get; set; }

		[DataMember(IsRequired = true)]
		[Required]
		public virtual string Username { get; set; }

		[DataMember]
		public virtual User User { get; set; }

		[DataMember]
		public virtual DateTime Created { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as TreatmentPlan;

			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return this.PatientId == other.PatientId &&
				this.TreatmentOptionId == other.TreatmentOptionId;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = GetType().GetHashCode();
				hash = (hash * 31) ^ PatientId.GetHashCode();
				hash = (hash * 31) ^ TreatmentOptionId.GetHashCode();

				return hash;
			}
		}
	}
}