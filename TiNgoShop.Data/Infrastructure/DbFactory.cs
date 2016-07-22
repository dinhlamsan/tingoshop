namespace TiNgoShop.Data.Infrastructure
{
    //DBContext thay vì new trực tiếp thì sẽ thông qua Factory này.
    public class DbFactory : Disposable, IDbFactory
    {
        private TiNgoShopDbContext dbContext;

        public TiNgoShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TiNgoShopDbContext());
        }

        public override void DisposeCore()
        {
            if (dbContext != null) dbContext.Dispose();
        }
    }
}