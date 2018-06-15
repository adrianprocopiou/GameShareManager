using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameShareManager.Startup))]
namespace GameShareManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
