using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DbMigrator;
using Users.Model;

namespace Users.Repository
{
    public class AddressRepository(DBContext dbContext) : BaseRepository(dbContext), IAddressRepository
    {
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
