using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyElectronicJournalWebsite.Startup))]
namespace MyElectronicJournalWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
