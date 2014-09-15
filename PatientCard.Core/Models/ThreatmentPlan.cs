using System;

namespace PatientCard.Core.Models
{
	public class ThreatmentPlan : IEntity<Tuple<int, int>>
	{
		public Tuple<int,int> Key { get { return new Tuple<int,int>(PatientId, Option); } }

		public virtual int PatientId { get; set; }

		public virtual int Option { get; set; }

		public virtual string Description { get; set; }

		public virtual string Username { get; set; }

		public virtual DateTime Created { get; set; }
	}
}