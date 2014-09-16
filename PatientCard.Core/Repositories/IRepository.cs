using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Repositories
{
	public interface IRepository<TEntity, TKey> where TEntity :IEntity<TKey>
	{
		TEntity Get(TEntity key);

		IList<TEntity> GetAll();

		bool CheckExist(TEntity entity);

		void Create(TEntity item);
		void Update(TEntity item);
		void Delete(TEntity item);
	}

	public interface IRepository<TEntity> : IRepository<TEntity, string> where TEntity : IEntity
	{
		
	}
}