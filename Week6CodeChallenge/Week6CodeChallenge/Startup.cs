using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6CodeChallenge.Startup))]
namespace Week6CodeChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
