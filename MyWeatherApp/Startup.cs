using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyWeatherApp.Startup))]
namespace MyWeatherApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
