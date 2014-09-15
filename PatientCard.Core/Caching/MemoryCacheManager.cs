using System.Runtime.Caching;

namespace PatientCard.Core.Caching
{
	public class MemoryCacheManager : CacheManager
	{
		public override T GetCachedObject<T>(string key, System.Func<T> builder, System.DateTimeOffset expiration, bool allowCaching = true)
		{
			ObjectCache cache = MemoryCache.Default;
			var instance = (T)cache[key];

			if (instance == null)
			{
				instance = builder();

				if (allowCaching)
				{
					cache.Set(key, instance, expiration);
				}
			}
			return instance;
		}
	}
}