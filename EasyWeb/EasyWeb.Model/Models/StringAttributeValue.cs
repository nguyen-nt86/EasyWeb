using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class StringAttributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public string Value { get; set; }

        public virtual Attribute Attribute { get; set; }
    }
}
