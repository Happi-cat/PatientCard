using System.Collections.Generic;
using PatientCard.Core.Models;

namespace PatientCard.Core.Services.Interfaces
{
    public interface IService<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        TEntity Get(TEntity key);

        IList<TEntity> GetAll();

        void Store(TEntity item);
        void Delete(TEntity item);
    }
}