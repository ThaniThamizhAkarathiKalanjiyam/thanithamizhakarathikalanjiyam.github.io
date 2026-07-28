using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
using MudBlazor.Services;
using System.Configuration;
using System.Net.Http;
using TTAK_BLZRV2.Data;

namespace TTAK_BLZRV2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            using var stream = FileSystem
                  .OpenAppPackageFileAsync("appsettings.json")
                  .GetAwaiter()
                  .GetResult();

            builder.Configuration.AddJsonStream(stream);
            builder.Services.AddSingleton<DatabaseInitializer>();


            var dbFileName = builder.Configuration["DBFileName"] ?? "Chinook_Sqlite.sqlite";

            //var dbFilePath = Path.Combine(
            //         FileSystem.AppDataDirectory,
            //         dbFileName);

            //if (!File.Exists(dbFilePath))
            //{
            //    var source =
            //        FileSystem.OpenAppPackageFileAsync(dbFileName)
            //                  .GetAwaiter()
            //                  .GetResult();

            //    var destination =
            //        File.Create(dbFilePath);

            //    source.CopyTo(destination);
            //}

            builder.Services.AddDbContext<MainContext>(options =>
            {
                //string path = Path.Combine(Directory.GetCurrentDirectory(), "App_Data", "SQLITEDB1.sqlite");
                string path = Path.Combine(FileSystem.AppDataDirectory, dbFileName);

                var dbFileFullPath = string.Format("Data Source={0};", path);

                //options.UseSqlite(Configuration["ConnectionString:DefaultConnection"].ToString());
                options.UseSqlite(dbFileFullPath);

            });

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddMudServices();

            return builder.Build();
        }
    }
}
