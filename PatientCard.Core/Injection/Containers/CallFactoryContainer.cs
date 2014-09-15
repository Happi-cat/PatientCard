using System;
using System.Collections.Generic;

namespace PatientCard.Core.Injection.Containers
{
	internal class CallTimeFactoryContainer : BaseContainer, IFactoryContainer
	{
		private readonly Dictionary<string, Func<object>> _builders = new Dictionary<string, Func<object>>();

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
				return _builders[key]();
			}
			return null;
		}

		public IFactoryContainer Register(Type type, Func<object> builder)
		{
			if (_builders.ContainsKey(GetKey(type)))
			{
				throw new ArgumentException("This type has been registered");
			}
			_builders.Add(GetKey(type), builder);
			return this;
		}

		public IFactoryContainer Register(string key, Func<object> builder)
		{
			if (_builders.ContainsKey(key))
			{
				throw new ArgumentException("This key has been registered");
			}
			_builders.Add(key, builder);
			return this;
		}

		public IFactoryContainer Register<T>(Func<T> builder)
		{

			if (_builders.ContainsKey(GetKey<T>()))
			{
				throw new ArgumentException("This type has been registered");
			}
			_builders.Add(GetKey<T>(),() => builder());
			return this;
		} 
	}
}