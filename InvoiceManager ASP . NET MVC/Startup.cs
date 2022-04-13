using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InvoiceManager_ASP.NET_MVC.Startup))]
namespace InvoiceManager_ASP.NET_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
