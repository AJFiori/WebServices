using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassWalkThrough.Startup))]
namespace InClassWalkThrough
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
