using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;

namespace TiNgoShop.Data.Repositories
{
    public interface IFooterRespository
    {
    }

    public class FooterRespository : RepositoryBase<Footer>, IFooterRespository
    {
        public FooterRespository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}