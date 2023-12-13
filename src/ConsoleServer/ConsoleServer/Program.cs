using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace ConsoleServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:5001");
            config.Routes.MapHttpRoute("ControllerBasedRoute", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            using (var httpSever = new HttpSelfHostServer(config))
            {
                httpSever.OpenAsync().Wait();
                Console.WriteLine("Server is listening requests at http://localhost:5001");
                Console.ReadLine();
            }
        }
    }
}
