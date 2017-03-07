using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FantasyWatch.Startup))]
namespace FantasyWatch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
