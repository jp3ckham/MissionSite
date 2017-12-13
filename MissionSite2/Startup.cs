using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionSite2.Startup))]
namespace MissionSite2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
