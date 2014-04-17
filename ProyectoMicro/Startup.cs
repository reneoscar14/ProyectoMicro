using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoMicro.Startup))]
namespace ProyectoMicro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
