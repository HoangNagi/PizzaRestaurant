using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaRestaurant.Startup))]
namespace PizzaRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
