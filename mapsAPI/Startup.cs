using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mapsAPI.Startup))]
namespace mapsAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
