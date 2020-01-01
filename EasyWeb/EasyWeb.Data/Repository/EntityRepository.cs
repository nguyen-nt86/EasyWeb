using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IEntityRepository
    { 
    }
    public class EntityRepository: RepositoryBase<Entity>, IEntityRepository
    {
        public EntityRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
