using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hydrangea_58.Startup))]
namespace hydrangea_58
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
