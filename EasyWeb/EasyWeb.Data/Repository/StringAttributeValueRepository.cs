using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IStringAttributeValueRepository
    { }
    public class StringAttributeValueRepository: RepositoryBase<StringAttributeValue>, IStringAttributeValueRepository
    {
        public StringAttributeValueRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
