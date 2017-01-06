using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XIRPL1_02_HelloWorld.Startup))]
namespace XIRPL1_02_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
