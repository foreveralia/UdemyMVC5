using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyMVC5.Startup))]
namespace UdemyMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
