using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoFront.Startup))]
namespace ContosoFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
