using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_git.Startup))]
namespace Testing_git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);//gmdsmgdsklsdmvsdlm
        }
    }
}
