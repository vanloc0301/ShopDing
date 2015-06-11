using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopDing.Web.Startup))]
namespace ShopDing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
