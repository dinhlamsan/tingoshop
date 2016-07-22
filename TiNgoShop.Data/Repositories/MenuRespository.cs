using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IMenuRespository { }

    public class MenuRespository : RepositoryBase<Menu>, IMenuRespository
    {
        public MenuRespository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}