using TTAK_BLZRV2.Shared.Services;
using TTAK_BLZRV2.Web.Components;
using TTAK_BLZRV2.Web.Services;

namespace TTAK_BLZRV2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            // Add device-specific services used by the TTAK_BLZRV2.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();
            app.MapStaticAssets();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(
                    typeof(TTAK_BLZRV2.Shared._Imports).Assembly,
                    typeof(TTAK_BLZRV2.Web.Client._Imports).Assembly);

            app.Run();
        }
    }
}
