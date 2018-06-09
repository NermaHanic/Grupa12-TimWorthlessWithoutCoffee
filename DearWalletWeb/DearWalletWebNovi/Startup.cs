using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DearWalletWebNovi.Startup))]
namespace DearWalletWebNovi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
