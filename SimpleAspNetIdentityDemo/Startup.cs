using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAspNetIdentityDemo.Startup))]
namespace SimpleAspNetIdentityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
