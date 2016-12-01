using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fiori_Final.Startup))]
namespace Fiori_Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
