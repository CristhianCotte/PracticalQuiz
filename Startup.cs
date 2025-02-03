using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticalQuiz.Startup))]
namespace PracticalQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
