using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaundaryManagement.Startup))]
namespace LaundaryManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
