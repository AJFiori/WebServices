using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeFinal.Startup))]
namespace PracticeFinal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
