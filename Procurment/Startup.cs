using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Procurment.Startup))]
namespace Procurment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
