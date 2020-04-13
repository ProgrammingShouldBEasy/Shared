using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SharedMVC.Startup))]
namespace SharedMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
