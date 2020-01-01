using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IWardRepository
    { }
    public class WardRepository: RepositoryBase<Ward>, IWardRepository
    {
        public WardRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
