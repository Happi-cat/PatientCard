using System.Collections.Generic;

namespace PatientCard.Core.Repositories
{
	public interface IRepository<TEntity>
	{
		TEntity Get(TEntity key);

		IList<TEntity> GetAll();

		bool CheckExist(TEntity entity);

		void Create(TEntity item);
		void Update(TEntity item);
		void Delete(TEntity item);
	}
}