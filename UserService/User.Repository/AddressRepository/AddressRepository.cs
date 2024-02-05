using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DbMigrator;
using Users.Model;
using Users.Repository.Base;

namespace Users.Repository.AddressRepository
{
    public class AddressRepository : BaseRepository, IAddressRepository
    {
        public AddressRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public void CreateAddress(Address address)
        {
            _dbContext.Address.Add(address);
            _dbContext.SaveChanges();
        }

        public async Task<List<Address>> GetAllAddress()
        {
            return await _dbContext.Address.ToListAsync();
        }
    }
}
