namespace DuyShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DuyShopDbContext dbContext;

        public DuyShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DuyShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}