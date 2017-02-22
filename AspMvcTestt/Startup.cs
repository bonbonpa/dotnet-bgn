using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcTestt.Startup))]
namespace AspMvcTestt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
