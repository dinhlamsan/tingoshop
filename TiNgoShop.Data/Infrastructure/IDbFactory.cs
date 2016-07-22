using System;

namespace TiNgoShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TiNgoShopDbContext Init();
    }
}