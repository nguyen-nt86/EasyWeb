using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IAttributeTypeRepository
    { }
    public class AttributeTypeRepository: RepositoryBase<AttributeType>, IAttributeTypeRepository
    {
        public AttributeTypeRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
