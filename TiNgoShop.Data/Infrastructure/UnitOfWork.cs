namespace TiNgoShop.Data.Infrastructure
{
    //Nhiệm vụ commit đảm bảo transaction được thành công toàn bộ(nếu 2 tác vụ trở lên)
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private TiNgoShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TiNgoShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}