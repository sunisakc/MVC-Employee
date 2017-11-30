using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeRegister.Startup))]
namespace EmployeeRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
