using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DbMigrator;
using Users.Model;

namespace Users.Repository
{
    public class BaseRepository
    {
        public readonly DBContext _dbContext;
        public BaseRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
