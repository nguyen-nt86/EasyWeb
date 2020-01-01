using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IAccountRepository
    {

    }
    public class AccountRepository: RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
