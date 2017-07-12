using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerBack2.Startup))]
namespace FlowerBack2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
