namespace PatientCard.Core.Models
{
	public class VisitDiary : IEntity<int>
	{
		public virtual int Key { get; set; }

		public virtual int PatientId { get; set; }

		public virtual string Username { get; set; }

	}
}