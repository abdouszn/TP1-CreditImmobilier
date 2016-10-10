using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP1_CreditImmobilier.Startup))]
namespace TP1_CreditImmobilier
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
