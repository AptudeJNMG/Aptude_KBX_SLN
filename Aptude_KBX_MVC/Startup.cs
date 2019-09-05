using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aptude_KBX_MVC.Startup))]
namespace Aptude_KBX_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
