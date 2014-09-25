using System.Collections.Generic;
using NHibernate;
using PatientCard.Core.Models;
using PatientCard.Core.Repositories;

namespace PatientCard.Repositories.NHibernate
{
	public class NHibernateRepository<TEntity, TKey> :IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
	{
		public TEntity Get(TEntity key)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<TEntity>(key.Key);
			}
		}

		public IList<TEntity> GetAll()
		{
			IList<TEntity> result;
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				result = session.CreateCriteria<TEntity>().List<TEntity>();
				transaction.Commit();
			}
			return result;
		}

		public bool CheckExist(TEntity entity)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			{
				return session.Get<TEntity>(entity.Key) != null;
			}
		}

		public void Create(TEntity item)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				session.Save(item);
				transaction.Commit();
			}
		}

		public void Update(TEntity item)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				session.Update(item);
				transaction.Commit();
			}
		}

		public void Delete(TEntity item)
		{
			using (ISession session = NHibernateHelper.OpenSession())
			using (ITransaction transaction = session.BeginTransaction())
			{
				session.Delete(item);
				transaction.Commit();
			}
		}
	}
}