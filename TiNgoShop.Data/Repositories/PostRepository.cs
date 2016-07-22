using System;
using System.Collections.Generic;
using TiNgoShop.Data.Infrastructure;
using TiNgoShop.Model.Models;
using System.Linq;
namespace TiNgoShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int PageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int PageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.Id equals pt.PostId
                        where pt.TagId == tag & p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((PageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}