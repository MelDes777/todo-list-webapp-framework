using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(todo_framework.Startup))]
namespace todo_framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
