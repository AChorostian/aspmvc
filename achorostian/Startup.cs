using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(achorostian.Startup))]
namespace achorostian
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
