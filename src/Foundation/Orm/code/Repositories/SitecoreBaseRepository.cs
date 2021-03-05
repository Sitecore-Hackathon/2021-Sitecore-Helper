using Glass.Mapper.Sc;
using Sitecore.Demo.Platform.Foundation.DependencyInjection;
using SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.DI;

namespace SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.Repositories
{
    [Service(typeof(ISitecoreBaseRepository))]
    public class SitecoreBaseRepository : ISitecoreBaseRepository
    {
        private readonly ISitecoreContext _sitecoreContext;

        public SitecoreBaseRepository(ISitecoreContext sitecoreContext)
        {
            _sitecoreContext = sitecoreContext;
        }
        public T GetItem<T>(string contentItem, bool isLazy = false, bool inferType = false) where T : class
        {
            return _sitecoreContext.GetItem<T>(contentItem, isLazy, inferType);
        }
        public T GetCurrentItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            return _sitecoreContext.GetCurrentItem<T>(isLazy, inferType);
        }
        public T GetHomeItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            return _sitecoreContext.GetHomeItem<T>(isLazy, inferType);
        }
        public T GetRootItem<T>(bool isLazy = false, bool inferType = false) where T : class
        {
            return _sitecoreContext.GetRootItem<T>(isLazy, inferType);
        }
        public T QuerySingleRelative<T>(string query, bool isLazy = false, bool inferType = false) where T : class
        {
            return _sitecoreContext.QuerySingleRelative<T>(query, isLazy, inferType);
        }
    }
}