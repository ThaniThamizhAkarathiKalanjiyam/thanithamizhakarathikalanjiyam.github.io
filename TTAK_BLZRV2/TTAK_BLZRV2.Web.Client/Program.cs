using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TTAK_BLZRV2.Shared.Services;
using TTAK_BLZRV2.Web.Client.Services;

namespace TTAK_BLZRV2.Web.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Add device-specific services used by the TTAK_BLZRV2.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            await builder.Build().RunAsync();
        }
    }
}
