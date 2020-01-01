using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        EasyWebContext _dbContext = null;
        IDbFactory _dbFactory = null;
        
        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public EasyWebContext DbContext
        {
            get
            {
                return _dbContext ?? (_dbFactory.Init());
            }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public void Transaction(Action callback)
        {
            using (var transaction = DbContext.Database.BeginTransaction())
            {
                try
                {
                    callback.Invoke();
                    Commit();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw new Exception();
                }
            }
        }
    }
}
