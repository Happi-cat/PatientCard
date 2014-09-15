using System;
using System.Collections.Generic;
using PatientCard.Core.Repositories;
using PatientCard.Core.Services.Interfaces;

namespace PatientCard.Core.Services
{
    public class MyService<T> : IMyService<T>
    {
        public MyService(IRepository<T> myRepository)
        {
            MyRepository = myRepository;
        }

        protected IRepository<T> MyRepository { get; private set; }

        public T GetMyItem(T key)
        {
            return MyRepository.Get(key);
        }

        public virtual IList<T> GetItems()
        {
            throw new NotSupportedException();
        }

        public IList<T> GetMyItems()
        {
            return MyRepository.GetAll();
        }

        public void StoreMyItem(T item)
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

        public void DeleteMyItem(T item)
        {
            if (MyRepository.CheckExist(item))
            {
                MyRepository.Delete(item);
            }

        }
    }
}