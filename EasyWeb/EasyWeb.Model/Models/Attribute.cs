using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributeGroupDetails = new HashSet<AttributeGroupDetails>();
            OptionAttributeValue = new HashSet<OptionAttributeValue>();
            StringAttributeValue = new HashSet<StringAttributeValue>();
            TextAttributeValue = new HashSet<TextAttributeValue>();
        }

        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public int? AttributeTypeId { get; set; }
        public int? AttributeGroupId { get; set; }

        public virtual AttributeType AttributeType { get; set; }
        public virtual DateTimeAttributeValue DateTimeAttributeValue { get; set; }
        public virtual DecimalAttributeValue DecimalAttributeValue { get; set; }
        public virtual NumberAttributeValue NumberAttributeValue { get; set; }
        public virtual ICollection<AttributeGroupDetails> AttributeGroupDetails { get; set; }
        public virtual ICollection<OptionAttributeValue> OptionAttributeValue { get; set; }
        public virtual ICollection<StringAttributeValue> StringAttributeValue { get; set; }
        public virtual ICollection<TextAttributeValue> TextAttributeValue { get; set; }
    }
}
