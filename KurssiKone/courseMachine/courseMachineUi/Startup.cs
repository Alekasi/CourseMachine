using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(courseMachineUi.Startup))]
namespace courseMachineUi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
