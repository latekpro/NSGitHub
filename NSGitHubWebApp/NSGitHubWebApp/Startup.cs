using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NSGitHubWebApp.Startup))]
namespace NSGitHubWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
