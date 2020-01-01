using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface INumberAttributeRepository
    {

    }
    public class NumberAttributeValueRepository: RepositoryBase<NumberAttributeValue>, INumberAttributeRepository
    {
        public NumberAttributeValueRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
