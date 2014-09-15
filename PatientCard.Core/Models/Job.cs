namespace PatientCard.Core.Models
{
	public class Job : IEntity
	{
		public virtual string Key { get { return Name; } }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }
	}
}