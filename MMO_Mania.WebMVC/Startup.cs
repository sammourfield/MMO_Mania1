using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MMO_Mania.WebMVC.Startup))]
namespace MMO_Mania.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
