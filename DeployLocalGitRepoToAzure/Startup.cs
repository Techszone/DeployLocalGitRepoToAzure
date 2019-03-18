using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeployLocalGitRepoToAzure.Startup))]
namespace DeployLocalGitRepoToAzure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
