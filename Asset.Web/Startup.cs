using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asset.Web.Startup))]
namespace Asset.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
