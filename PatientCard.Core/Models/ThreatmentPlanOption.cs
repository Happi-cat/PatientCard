namespace PatientCard.Core.Models
{
	public class ThreatmentPlanOption : IEntity<int>
	{
		public virtual int Key { get; set; }

		public virtual string Name { get; set; }

		public virtual int Group { get; set; }

		public virtual int Order { get; set; }
	}
}