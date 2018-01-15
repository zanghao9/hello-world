using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MineClearance.Startup))]
namespace MineClearance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
