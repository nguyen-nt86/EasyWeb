using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class OptionAttributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public int? Source { get; set; }

        public virtual Attribute Attribute { get; set; }
    }
}
