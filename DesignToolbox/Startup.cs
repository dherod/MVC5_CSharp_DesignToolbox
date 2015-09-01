using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesignToolbox.Startup))]
namespace DesignToolbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
