using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public int? UserProfileId { get; set; }
        public string Address1 { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? WardId { get; set; }
        public bool? IsMain { get; set; }
        public bool? IsDelivery { get; set; }

        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual Ward Ward { get; set; }
    }
}
