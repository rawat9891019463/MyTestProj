using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTestProj.Startup))]
namespace MyTestProj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
