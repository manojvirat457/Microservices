using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DbMigrator;
using Users.Model;
using Users.Repository.Base;

namespace Users.Repository.UserRepository
{
    public class UserRepository  : BaseRepository, IUserRepository
    {
        public UserRepository(DBContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUser()
        {
            var con = await _dbContext.Users.ToListAsync();
            return con.ToList();
        }
    }
}
