using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UmbracoExperiment.Startup))]
namespace UmbracoExperiment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
