using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuongHyKhang_2011062170_BigSchool.Startup))]
namespace VuongHyKhang_2011062170_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
