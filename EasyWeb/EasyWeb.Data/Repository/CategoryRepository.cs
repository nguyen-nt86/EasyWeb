using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface ICategoryRepository
    { }
    public class CategoryRepository: RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
