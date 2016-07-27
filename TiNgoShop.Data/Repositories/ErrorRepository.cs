using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
    }

    public class ErrorRespository : RepositoryBase<Error>, IErrorRepository
    {
        public ErrorRespository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}