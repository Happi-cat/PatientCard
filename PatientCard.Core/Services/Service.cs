using System;
using System.Collections.Generic;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
    public abstract class Service<TEntity, TKey> : IService<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        protected Service(IRepository<TEntity, TKey> repository)
        {
            Repository = repository;
        }

        protected IRepository<TEntity, TKey> Repository { get; private set; }

        public TEntity Get(TEntity key)
        {
            return Repository.Get(key);
        }

        public IList<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

		public void Store(TEntity item)
        {
            if (Repository.CheckExist(item))
            {
                Repository.Update(item);
            }
            else
            {
                Repository.Create(item);
            }
        }

		public void Delete(TEntity item)
        {
            if (Repository.CheckExist(item))
            {
                Repository.Delete(item);
            }

        }
    }
}