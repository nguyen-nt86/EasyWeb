using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class EntityDetails
    {
        public int EntityId { get; set; }
        public int AttributeGroupId { get; set; }

        public virtual AttributeGroup AttributeGroup { get; set; }
        public virtual Entity Entity { get; set; }
    }
}
