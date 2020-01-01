using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IOptionAttributeValueRepository
    { }
    public class OptionAttributeValueRepository: RepositoryBase<OptionAttributeValue>, IOptionAttributeValueRepository
    {
        public OptionAttributeValueRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
