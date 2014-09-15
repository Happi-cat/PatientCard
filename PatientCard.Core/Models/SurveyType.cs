namespace PatientCard.Core.Models
{
	public class SurveyType : IEntity
	{
		public virtual string Key { get { return Name; } }

		public virtual string Name { get; set; }

	}
}