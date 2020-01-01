using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Entity
    {
        public Entity()
        {
            EntityDetails = new HashSet<EntityDetails>();
        }

        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string EntitySlug { get; set; }
        public int? CategoryId { get; set; }
        public int? EntityParent { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? Author { get; set; }
        public int? Editor { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<EntityDetails> EntityDetails { get; set; }
    }
}
