using System;
using System.Collections.Generic;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
    public class MyService<TEntity, TKey> : IMyService<TEntity, TKey> where TEntity : IEntity<TKey>
    {
        public MyService(IRepository<TEntity, TKey> myRepository)
        {
            MyRepository = myRepository;
        }

        protected IRepository<TEntity, TKey> MyRepository { get; private set; }

        public TEntity GetMyItem(TKey key)
        {
            return MyRepository.Get(key);
        }

		public virtual IList<TEntity> GetItems()
        {
            throw new NotSupportedException();
        }

        public IList<TEntity> GetMyItems()
        {
            return MyRepository.GetAll();
        }

		public void StoreMyItem(TEntity item)
        {
            if (MyRepository.CheckExist(item))
            {
                MyRepository.Update(item);
            }
            else
            {
                MyRepository.Create(item);
            }
        }

		public void DeleteMyItem(TEntity item)
        {
            if (MyRepository.CheckExist(item))
            {
                MyRepository.Delete(item);
            }

        }
    }

	public class MyService<TEntity> : MyService<TEntity, string> where TEntity : IEntity
	{
		public MyService(IRepository<TEntity, string> myRepository) : base(myRepository)
		{
		}
	}
}