using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNet_MVC_Solution.Startup))]
namespace ASPNet_MVC_Solution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
