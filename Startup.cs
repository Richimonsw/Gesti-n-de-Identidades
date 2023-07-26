using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RolesUsuario.Startup))]
namespace RolesUsuario
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
