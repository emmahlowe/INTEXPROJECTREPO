using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INTEXPROJECT.Startup))]
namespace INTEXPROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
