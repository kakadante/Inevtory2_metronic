using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inevtory2.Startup))]
namespace Inevtory2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
