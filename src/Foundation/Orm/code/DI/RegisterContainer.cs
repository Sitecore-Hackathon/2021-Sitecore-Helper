using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.Repositories;
using Microsoft.Extensions.DependencyInjection;

using Sitecore.DependencyInjection;

namespace SitecoreHelper.Hackathon2021.Dev.Foundation.Orm.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IGlassHtml, GlassHtml>();
            serviceCollection.AddTransient<ISitecoreBaseRepository, SitecoreBaseRepository>();
        }
    }
}