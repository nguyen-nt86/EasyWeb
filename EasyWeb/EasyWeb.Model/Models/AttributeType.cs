using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class AttributeType
    {
        public AttributeType()
        {
            Attribute = new HashSet<Attribute>();
        }

        public int AttributeTypeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }

        public virtual ICollection<Attribute> Attribute { get; set; }
    }
}
