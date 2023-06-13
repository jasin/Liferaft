using Microsoft.Extensions.Configuration;

namespace DatabaseAccess.Connection;

public static class MssqlConnection
{
    public static string BuildConnectionString(IConfiguration configRoot)
    {
        var mssqlDatabase = new MssqlDatabase();
        configRoot.GetSection(nameof(MssqlDatabase)).Bind(mssqlDatabase);

        return $"Server={mssqlDatabase.Instance};Database={mssqlDatabase.DatabaseName};Trusted_Connection=true;Encrypt=false";
    }
}

public class MssqlDatabase
{
    public string? Instance { get; set;}
    public string? DatabaseName { get; set; }
}