using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaXMXasp.Startup))]
namespace MediaXMXasp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
