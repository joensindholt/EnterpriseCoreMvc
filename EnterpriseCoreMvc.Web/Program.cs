using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace EnterpriseCoreMvc.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                // Uncomment for running on "bash on windows" .UseUrls("http://127.0.0.1:8080")
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}