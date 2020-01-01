using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IUserProfileRepository
    { }
    public class UserProfileRepository:RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
