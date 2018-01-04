using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExercise.Startup))]
namespace MVCExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
