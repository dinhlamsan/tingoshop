using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IProductTagRepository { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}