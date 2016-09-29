using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactTest.Startup))]
namespace ReactTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
