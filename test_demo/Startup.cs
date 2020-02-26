using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_demo.Startup))]
namespace test_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
