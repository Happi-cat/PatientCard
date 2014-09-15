using System;
using System.Collections.Generic;
using System.Linq;
using PatientCard.Core.Injection.Containers;

namespace PatientCard.Core.Injection
{
	public class BuildFactory : IFactoryContainer
	{
		private readonly IFactoryContainer _factoryContainers = new LazyFactoryContainer();
		private readonly List<IFactoryContainer> _containers = new List<IFactoryContainer>();

		public BuildFactory()
		{
			_factoryContainers.Register(() => new LazyFactoryContainer());
			_factoryContainers.Register(() => new CallTimeFactoryContainer());
			_factoryContainers.Register(() => new ThreadLocalFactoryContainer());
		}

		public IFactoryContainer Singleton()
		{
			return RegisterUsage(_factoryContainers.GetInstance<LazyFactoryContainer>());
		}

		public IFactoryContainer Transient()
		{
			return RegisterUsage(_factoryContainers.GetInstance<CallTimeFactoryContainer>());
		}

		public IFactoryContainer PerThread()
		{
			return RegisterUsage(_factoryContainers.GetInstance<ThreadLocalFactoryContainer>());
		}

		public T GetInstance<T>() where T : class
		{
			return _containers.Select(container => container.GetInstance<T>()).FirstOrDefault(instance => instance != null);
		}

		public object GetInstance(Type type)
		{
			return _containers.Select(container => container.GetInstance(type)).FirstOrDefault(instance => instance != null);
		}

		public object GetInstance(string key)
		{
			return _containers.Select(container => container.GetInstance(key)).FirstOrDefault(instance => instance != null);
		}

		public IFactoryContainer Register(Type type, Func<object> builder)
		{
			throw new InvalidOperationException();
		}

		public IFactoryContainer Register(string key, Func<object> builder)
		{
			throw new InvalidOperationException();
		}

		public IFactoryContainer Register<T>(Func<T> builder)
		{
			throw new InvalidOperationException();
		}

		private IFactoryContainer RegisterUsage(IFactoryContainer container)
		{
			if (!_containers.Contains(container))
			{
				_containers.Add(container);
			}
			return container;
		}
	}
}