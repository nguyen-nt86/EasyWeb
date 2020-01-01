using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data.Repository
{
    public interface ICityRepository
    { }
    public class CityRepository: RepositoryBase<City>, ICityRepository
    {
        public CityRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
