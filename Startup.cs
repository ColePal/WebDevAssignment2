using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilmFriends.Startup))]
namespace FilmFriends
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
