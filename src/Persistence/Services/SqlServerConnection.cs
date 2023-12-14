using Application.Abstractions.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Persistence.Services;
public class SqlServerConnection : IDbContext
{
    private readonly string _connectionString;
    // 需安裝套件(Microsoft.Extensions.Configuration.Abstractions)
    // 才能取得IConfiguration(取用appsettings.json設定檔)
    public SqlServerConnection(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ApplicationException("Connection string is missing");
    }
    public IDbConnection Create()
    {
        // 安裝Microsoft.Data.SqlClient
        return new SqlConnection(_connectionString);
    }
}
