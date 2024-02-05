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
