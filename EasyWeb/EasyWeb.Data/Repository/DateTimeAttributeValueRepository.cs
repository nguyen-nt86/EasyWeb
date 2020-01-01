using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IDateTimeAttributeValueRepository
    {

    }
    public class DateTimeAttributeValueRepository: RepositoryBase<DateTimeAttributeValue>, IDateTimeAttributeValueRepository
    {
        public DateTimeAttributeValueRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
