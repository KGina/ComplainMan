using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplainManager.Startup))]
namespace ComplainManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
