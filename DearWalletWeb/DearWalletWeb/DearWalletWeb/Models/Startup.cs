using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DearWalletWeb.Startup))]
namespace DearWalletWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
