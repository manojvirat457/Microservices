using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Model;

namespace Users.Repository.AddressRepository
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAllAddress();
        void CreateAddress(Address address);
    }
}
