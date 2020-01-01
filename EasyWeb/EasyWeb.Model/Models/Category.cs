using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Category
    {
        public Category()
        {
            Entity = new HashSet<Entity>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Entity> Entity { get; set; }
    }
}
