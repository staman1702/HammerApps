using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HammerAppMVC.Startup))]
namespace HammerAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
