using System;

namespace PatientCard.Core.Caching
{
	public class CacheManager
	{
		public virtual T GetCachedObject<T>(string key, Func<T> builder, DateTimeOffset expiration, bool allowCaching = true)
			where T : class
		{
			return builder();
		}
	}
}