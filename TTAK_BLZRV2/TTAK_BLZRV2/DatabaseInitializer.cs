using Microsoft.Extensions.Configuration;

namespace TTAK_BLZRV2
{
    //public class DatabaseInitializer
    //{
    //    private readonly string _databasePath, dbFileName;
    //    //var dbFileName = builder.Configuration["DBFileName"] ?? "Chinook_Sqlite.sqlite";


    //    public DatabaseInitializer(IConfiguration configuration)
    //    {


    //        dbFileName = configuration["DBFileName"] ?? "Chinook_Sqlite.sqlite";

    //        _databasePath = Path.Combine(
    //           FileSystem.AppDataDirectory,
    //           dbFileName);
    //    }

    //    public async Task InitializeAsync()
    //    {
    //        //var dbFileName = configuration["DBFileName"] ?? "Chinook_SQLite.sqlite";

    //        if (File.Exists(_databasePath))
    //            return;

    //        await using (var source =
    //            await FileSystem.OpenAppPackageFileAsync(dbFileName))
    //        {

    //            using (var destination =
    //               new FileStream(
    //           _databasePath,
    //           FileMode.Create,
    //           FileAccess.Write,
    //           FileShare.None,
    //           81920,
    //           useAsync: true))
    //            {

    //                await source.CopyToAsync(destination);

    //                await destination.FlushAsync();
    //            }
    //        }
    //    }
    //}


    public class DatabaseInitializer
    {
        private readonly string _dbFileName;
        private readonly string _databasePath;

        public DatabaseInitializer(IConfiguration configuration)
        {
            _dbFileName =
                configuration["DBFileName"]
                ?? "Chinook_Sqlite.sqlite";

            _databasePath = Path.Combine(
                FileSystem.AppDataDirectory,
                _dbFileName);
        }

        public async Task InitializeAsync()
        {
            if (File.Exists(_databasePath))
                return;

            await using var source =
                await FileSystem.OpenAppPackageFileAsync(_dbFileName);

            await using var destination =
                File.Create(_databasePath);

            var buffer = new byte[81920];
            int bytesRead;

            while ((bytesRead = await source.ReadAsync(buffer)) > 0)
            {
                await destination.WriteAsync(
                    buffer.AsMemory(0, bytesRead));
            }

            await destination.FlushAsync();
        }
    }
}
