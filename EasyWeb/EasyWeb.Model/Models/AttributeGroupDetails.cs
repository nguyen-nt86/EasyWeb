using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class AttributeGroupDetails
    {
        public int AttributeGroupId { get; set; }
        public int AttributeId { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual AttributeGroup AttributeGroup { get; set; }
    }
}
