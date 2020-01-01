using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class DateTimeAttributeValue
    {
        public int ValueId { get; set; }
        public int? AttributeId { get; set; }
        public DateTime? Value { get; set; }

        public virtual Attribute ValueNavigation { get; set; }
    }
}
