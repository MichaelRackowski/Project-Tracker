using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using PrescriptionCapstone.Models;

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
