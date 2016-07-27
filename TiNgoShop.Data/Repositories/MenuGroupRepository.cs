using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup> { }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}