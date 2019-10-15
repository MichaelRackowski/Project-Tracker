using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrescriptionCapstone.Startup))]
namespace PrescriptionCapstone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
