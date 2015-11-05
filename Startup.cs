using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(net.Startup))]
namespace net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
