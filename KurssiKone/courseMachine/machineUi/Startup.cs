using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(machineUi.Startup))]
namespace machineUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
