using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryCrudOperarion.Startup))]
namespace JqueryCrudOperarion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
