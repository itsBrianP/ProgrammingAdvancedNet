using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Oefening1week1.Startup))]
namespace Oefening1week1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
