using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class AttributeGroup
    {
        public AttributeGroup()
        {
            AttributeGroupDetails = new HashSet<AttributeGroupDetails>();
            EntityDetails = new HashSet<EntityDetails>();
        }

        public int AttributeGroupId { get; set; }
        public string AttributeGroupName { get; set; }

        public virtual ICollection<AttributeGroupDetails> AttributeGroupDetails { get; set; }
        public virtual ICollection<EntityDetails> EntityDetails { get; set; }
    }
}
