using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeminaryStreet.Startup))]
namespace SeminaryStreet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
