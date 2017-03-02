using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SofyanHamdi_NetworkApp.Startup))]
namespace SofyanHamdi_NetworkApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
