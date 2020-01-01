using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            Address = new HashSet<Address>();
        }

        public int UserProfileId { get; set; }
        public int? AccountId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}
