using Microsoft.Owin;
using Owin;
using OperasWebSite;

namespace OperasWebSite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
