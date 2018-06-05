using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HallOfFame.Startup))]
namespace HallOfFame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
