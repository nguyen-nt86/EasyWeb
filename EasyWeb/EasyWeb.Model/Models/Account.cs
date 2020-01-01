using System;
using System.Collections.Generic;

namespace EasyWeb.Model
{
    public partial class Account
    {
        public Account()
        {
            UserProfile = new HashSet<UserProfile>();
        }

        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string SecurityStamp { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
