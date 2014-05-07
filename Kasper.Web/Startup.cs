using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kasper.Web.Startup))]
namespace Kasper.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
