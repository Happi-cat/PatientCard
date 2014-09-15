using System.Collections.Generic;

namespace PatientCard.Core.Services.Interfaces
{
    public interface IMyService<TEntity>
    {
        TEntity GetMyItem(TEntity key);

        IList<TEntity> GetItems();
        IList<TEntity> GetMyItems();

        void StoreMyItem(TEntity item);
        void DeleteMyItem(TEntity item);
    }
}