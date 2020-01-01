using System;
using System.Collections.Generic;
using System.Text;
using Attribute = EasyWeb.Model.Attribute;

namespace EasyWeb.Data
{
    public interface IAttributeRepository
    { }
    public class AttributeRepository: RepositoryBase<Attribute>, IAttributeRepository
    {
        public AttributeRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
