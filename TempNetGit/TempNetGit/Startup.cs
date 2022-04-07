using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempNetGit.Startup))]
namespace TempNetGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
