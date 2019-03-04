using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstGithub.Startup))]
namespace MyFirstGithub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
