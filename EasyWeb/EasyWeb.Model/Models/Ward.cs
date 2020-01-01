using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Ward
    {
        public Ward()
        {
            Address = new HashSet<Address>();
        }

        public int WardId { get; set; }
        public string WardName { get; set; }
        public int? DistrictId { get; set; }

        public virtual District District { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
