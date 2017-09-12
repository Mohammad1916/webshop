using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebshopApp.Startup))]
namespace WebshopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
