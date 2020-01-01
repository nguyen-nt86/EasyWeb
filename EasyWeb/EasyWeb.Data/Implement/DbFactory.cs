using Microsoft.EntityFrameworkCore;

namespace EasyWeb.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        EasyWebContext _dbContext = null;
        string _connectionString = string.Empty;
        public DbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public EasyWebContext Init()
        {
            return _dbContext ?? (new EasyWebContext(GetOption()));
        }
        private DbContextOptions<EasyWebContext> GetOption()
        {
            DbContextOptionsBuilder<EasyWebContext> optionBuilder = new DbContextOptionsBuilder<EasyWebContext>();
            optionBuilder.UseSqlServer(_connectionString);
            return optionBuilder.Options;
        }
        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
