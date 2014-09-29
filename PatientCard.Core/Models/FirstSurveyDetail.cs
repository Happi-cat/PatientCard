using System;
using System.Runtime.Serialization;

namespace PatientCard.Core.Models
{
	[DataContract]
	public class FirstSurveyDetail : IEntity<Tuple<int, int>>
	{
		public virtual Tuple<int, int> Key { get { return new Tuple<int, int>(PatientId, SurveyOptionId); } }

		[DataMember]
		public virtual int PatientId { get; set; }

		[DataMember]
		public virtual int SurveyOptionId { get; set; }

		[DataMember]
		public virtual bool YesNo { get; set; }

		[DataMember]
		public virtual string Detail { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as FirstSurveyDetail;

			if (ReferenceEquals(null, other)) return false;
			if (ReferenceEquals(this, other)) return true;

			return this.PatientId == other.PatientId &&
				this.SurveyOptionId == other.SurveyOptionId;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				int hash = GetType().GetHashCode();
				hash = (hash * 31) ^ PatientId.GetHashCode();
				hash = (hash * 31) ^ SurveyOptionId.GetHashCode();

				return hash;
			}
		}
	}
}