using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InClassAssignment.Startup))]
namespace InClassAssignment
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
