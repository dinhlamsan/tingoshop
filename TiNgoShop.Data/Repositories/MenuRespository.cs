using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IMenuRespository : IRepository<Menu> { }

    public class MenuRespository : RepositoryBase<Menu>, IMenuRespository
    {
        public MenuRespository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}