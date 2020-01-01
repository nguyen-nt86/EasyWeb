using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IAttributeGroupDetails
    { }
    public class AttributeGroupDetailsRpository: RepositoryBase<AttributeGroupDetails>, IAttributeGroupDetails
    {
        public AttributeGroupDetailsRpository(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
