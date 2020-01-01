using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
            District = new HashSet<District>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<District> District { get; set; }
    }
}
