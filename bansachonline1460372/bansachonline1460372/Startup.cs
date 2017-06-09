using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bansachonline1460372.Startup))]
namespace bansachonline1460372
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
