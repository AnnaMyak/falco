using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FALCO.Startup))]
namespace FALCO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
