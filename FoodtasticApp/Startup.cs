using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodtasticApp.Startup))]
namespace FoodtasticApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
