using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspMvcAuthv0.Startup))]
namespace AspMvcAuthv0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
