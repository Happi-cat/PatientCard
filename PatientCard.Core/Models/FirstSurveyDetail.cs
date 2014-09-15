using System;

namespace PatientCard.Core.Models
{
	public class FirstSurveyDetail : IEntity<Tuple<int, int>>
	{
		public Tuple<int,int> Key { get { return new Tuple<int,int>(PatientId, Option); } }

		public virtual int PatientId { get; set; }

		public virtual int Option { get; set; }

		public virtual bool YesNo { get; set; }

		public virtual string Detail { get; set; }
	}
}