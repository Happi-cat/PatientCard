namespace PatientCard.Core.Models
{
	public interface IEntity<TKey>
	{
		TKey Key { get; }
	}

	public interface IEntity : IEntity<string>
	{
	}
}