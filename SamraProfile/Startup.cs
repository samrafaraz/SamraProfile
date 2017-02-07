using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SamraProfile.Startup))]
namespace SamraProfile
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
