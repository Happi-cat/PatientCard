using PatientCard.Core.Caching;

namespace PatientCard.Core.Services
{
    public abstract class GateService
    {
        protected GateService(CacheManager cacheManager)
        {
            CacheManager = cacheManager;
        }

        protected CacheManager CacheManager { get; private set; }
    }
}