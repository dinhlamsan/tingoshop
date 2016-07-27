using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail> { }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}