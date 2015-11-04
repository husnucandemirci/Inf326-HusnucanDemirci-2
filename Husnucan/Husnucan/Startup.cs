using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Husnucan.Startup))]
namespace Husnucan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
