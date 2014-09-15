using System;

namespace PatientCard.Core.Models
{
	public class Survey : IEntity<int>
	{
		public virtual int Key { get; set; }

		public virtual int PatientId { get; set; }

		public virtual string Username { get; set; }

		public virtual string Type { get; set; }

		public virtual string Description { get; set; }

		public virtual string Created { get; set; }

		public virtual int Dose { get; set; }
	}
}