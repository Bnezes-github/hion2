using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hion.Startup))]
namespace Hion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
