using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunovaChallenge.Startup))]
namespace SunovaChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
