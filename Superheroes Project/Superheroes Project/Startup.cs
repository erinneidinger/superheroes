using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Superheroes_Project.Startup))]
namespace Superheroes_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
