using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public interface IProductRepository : IRepository<Product>
        {
            //Phương thức nghiệp vụ đặc thù không nằm trong RepositoryBase(nếu có) và cần kế thừa và inplement trong phương thức ProductRepository
        }
        public ProductRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
            //Kế thừa contructor, truyền vào dbFactory đồng thời cũng truyền vào contructor của RepositoryBase để khởi tạo ra RepositoryBase và có thể thao tác được
        }
    }
}