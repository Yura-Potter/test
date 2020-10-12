using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(No_name.Startup))]
namespace No_name
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
