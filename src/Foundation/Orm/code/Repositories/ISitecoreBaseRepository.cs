namespace SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.Repositories
{
    public interface ISitecoreBaseRepository
    {
        T GetItem<T>(string contentItem, bool isLazy = false, bool inferType = false) where T : class;
        T GetCurrentItem<T>(bool isLazy = false, bool inferType = false) where T : class;
        T GetHomeItem<T>(bool isLazy = false, bool inferType = false) where T : class;
        T GetRootItem<T>(bool isLazy = false, bool inferType = false) where T : class;
        T QuerySingleRelative<T>(string query, bool isLazy = false, bool inferType = false) where T : class;
    }
}
