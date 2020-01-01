using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class DecimalAttributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public decimal? Value { get; set; }

        public virtual Attribute ValueNavigation { get; set; }
    }
}
