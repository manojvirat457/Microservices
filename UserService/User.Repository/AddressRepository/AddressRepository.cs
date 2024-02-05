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

        public async Task<IEnumerable<Address>> GetAllAddress()
        {
            return await _dbContext.Address.ToListAsync();
        }
    }
}
