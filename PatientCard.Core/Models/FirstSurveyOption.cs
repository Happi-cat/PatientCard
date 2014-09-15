namespace PatientCard.Core.Models
{
	public class FirstSurveyOption : IEntity<int>
	{
		public virtual int Key { get; set; }

		public virtual string Name { get; set; }

	}
}