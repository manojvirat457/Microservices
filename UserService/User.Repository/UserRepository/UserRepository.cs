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
    public class UserRepository(DBContext dbContext) : BaseRepository(dbContext), IUserRepository
    {
        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public async Task<List<User>> GetAllUser()
        {
            var con = await _dbContext.Users
                .Include(x => x.Address)
                .ToListAsync();
            return con.ToList();
        }

    }
}
