using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheRideYouRent1.Startup))]
namespace TheRideYouRent1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
