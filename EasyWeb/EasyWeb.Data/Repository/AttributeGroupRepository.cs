using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IAttributeGroupRepository
    { }
    public class AttributeGroupRepository: RepositoryBase<AttributeGroup>, IAttributeGroupRepository
    {
        public AttributeGroupRepository(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
