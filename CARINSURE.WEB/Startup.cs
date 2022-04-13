using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CARINSURE.WEB.Startup))]
namespace CARINSURE.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
