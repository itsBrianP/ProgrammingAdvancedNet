using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroWeek2.Startup))]
namespace IntroWeek2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
