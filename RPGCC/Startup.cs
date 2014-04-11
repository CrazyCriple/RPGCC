using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RPGCC.Startup))]
namespace RPGCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
