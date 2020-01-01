using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class NumberAttributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public int? Value { get; set; }

        public virtual Attribute ValueNavigation { get; set; }
    }
}
