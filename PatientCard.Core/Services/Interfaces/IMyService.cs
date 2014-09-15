using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
    public interface IMyService<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        TEntity GetMyItem(TKey key);

        IList<TEntity> GetItems();
        IList<TEntity> GetMyItems();

        void StoreMyItem(TEntity item);
        void DeleteMyItem(TEntity item);
    }

	public interface IMyService<TEntity> : IMyService<TEntity, string> where TEntity : IEntity
	{
		
	}
}