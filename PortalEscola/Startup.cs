using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalEscola.Startup))]
namespace PortalEscola
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
