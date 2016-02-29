using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oefening1Week2.Startup))]
namespace Oefening1Week2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
