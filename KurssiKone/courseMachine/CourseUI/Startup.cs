using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseUI.Startup))]
namespace CourseUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
