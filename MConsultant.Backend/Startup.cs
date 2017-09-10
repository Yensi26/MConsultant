using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MConsultant.Backend.Startup))]
namespace MConsultant.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
