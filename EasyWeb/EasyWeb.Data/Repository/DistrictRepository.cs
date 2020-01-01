using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface IDistrictRepository 
    { }
    public class DistrictRepository: RepositoryBase<District>, IDecimalAttributeValueRepository
    {
        public DistrictRepository(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
