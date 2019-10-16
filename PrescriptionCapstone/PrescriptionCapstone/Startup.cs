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
            createRolesandUsers();
        }
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context))
        }
    }
}
