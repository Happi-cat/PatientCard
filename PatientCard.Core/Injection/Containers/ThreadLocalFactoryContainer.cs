using System;
using System.Collections.Generic;
using System.Threading;

namespace PatientCard.Core.Injection.Containers
{
	internal class ThreadLocalFactoryContainer : BaseContainer, IFactoryContainer
	{
		private readonly Dictionary<string, ThreadLocal<object>> _builders = new Dictionary<string, ThreadLocal<object>>();

		public object GetInstance(Type type)
		{
			return GetInstance(GetKey(type));
		}

		public T GetInstance<T>() where T : class
		{
			return (T)GetInstance(GetKey<T>());
		}

		public object GetInstance(string key)
		{
			if (_builders.ContainsKey(key))
			{
				return _builders[key].Value;
			}
			return null;
		}

		public IFactoryContainer Register(Type type, Func<object> builder)
		{
			if (_builders.ContainsKey(GetKey(type)))
			{
				throw new ArgumentException("This type has been registered");
			}
			_builders.Add(GetKey(type), new ThreadLocal<object>(builder));
			return this;
		}

		public IFactoryContainer Register(string key, Func<object> builder)
		{
			if (_builders.ContainsKey(key))
			{
				throw new ArgumentException("This key has been registered");
			}
			_builders.Add(key, new ThreadLocal<object>(builder));
			return this;
		}

		public IFactoryContainer Register<T>(Func<T> builder)
		{

			if (_builders.ContainsKey(GetKey<T>()))
			{
				throw new ArgumentException("This type has been registered");
			}
			_builders.Add(GetKey<T>(), new ThreadLocal<object>(() => builder()));
			return this;
		} 
	}
}