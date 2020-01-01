using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IDecimalAttributeValueRepository 
    { }
    public class DecimalAttributeValueRepository: RepositoryBase<DecimalAttributeValue>, IDecimalAttributeValueRepository
    {
        public DecimalAttributeValueRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
