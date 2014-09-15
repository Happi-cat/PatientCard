namespace PatientCard.Core.Models
{
	public class FirstSurvey :IEntity<int>
	{
		public virtual int Key { get { return PatientId; } }

		public virtual int PatientId { get; set; }

		public virtual string Reason { get; set; }

		public virtual string Face { get; set; }

		public virtual string Skin { get; set; }

		public virtual string Limbs { get; set; }

		public virtual string Bones { get; set; }
	}
}