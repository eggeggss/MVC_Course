using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod01_02.Startup))]
namespace Mod01_02
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
