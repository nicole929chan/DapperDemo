using System.Data;

namespace Application.Abstractions.Data;

public interface IDbContext
{
    public IDbConnection Create();
}
