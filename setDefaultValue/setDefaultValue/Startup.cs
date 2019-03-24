using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(setDefaultValue.Startup))]
namespace setDefaultValue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
