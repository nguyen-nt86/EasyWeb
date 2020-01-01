using EasyWeb.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWeb.Data
{
    public interface IAddressRepository
    { }
    public class AddressRepository: RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
