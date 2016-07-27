using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IFooterRespository:IRepository<Footer>
    {
    }

    public class FooterRespository : RepositoryBase<Footer>, IFooterRespository
    {
        public FooterRespository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}