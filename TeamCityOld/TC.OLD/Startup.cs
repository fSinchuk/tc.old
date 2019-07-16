using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TC.OLD.Startup))]
namespace TC.OLD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
