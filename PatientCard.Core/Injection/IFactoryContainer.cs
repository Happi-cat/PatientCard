using System;

namespace PatientCard.Core.Injection
{
	public interface IFactoryContainer
	{
		T GetInstance<T>() where T : class;
		object GetInstance(Type type);
		object GetInstance(string key);

		IFactoryContainer Register(Type type, Func<object> builder);
		IFactoryContainer Register(string key, Func<object> builder);
		IFactoryContainer Register<T>(Func<T> builder);
	}
}