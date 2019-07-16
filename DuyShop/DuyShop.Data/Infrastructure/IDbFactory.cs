using System;

namespace DuyShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        DuyShopDbContext Init();
    }
}