using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dershane_sistem.Startup))]
namespace Dershane_sistem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
