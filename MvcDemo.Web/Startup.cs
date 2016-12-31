using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDemo.Web.Startup))]
namespace MvcDemo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
