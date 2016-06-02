using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoUniversityMyVersion.Web.Startup))]
namespace ContosoUniversityMyVersion.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
