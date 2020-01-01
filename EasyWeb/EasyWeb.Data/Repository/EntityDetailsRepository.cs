using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IEntityDetailsRepository 
    {
    }
    public class EntityDetailsRepository: RepositoryBase<EntityDetails>, IEntityDetailsRepository
    {
        public EntityDetailsRepository(IDbFactory dbFactory):base(dbFactory)
        {
            
        }
    }
}
