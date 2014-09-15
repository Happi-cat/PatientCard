using System;

namespace PatientCard.Core.Injection.Containers
{
    public class BaseContainer
    {
        protected string GetKey<T>()
        {
            var type = typeof (T);
            if (type.IsGenericTypeDefinition)
            {
                return type.GetGenericTypeDefinition().FullName;
            }
            return type.FullName;
        }

		protected string GetKey(Type type)
		{
			return type.FullName;
		}
    }
}