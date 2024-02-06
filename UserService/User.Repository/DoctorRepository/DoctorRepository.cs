using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DbMigrator;

namespace Users.Repository
{
    public class DoctorRepository(DBContext dbContext) : BaseRepository(dbContext), IDoctorRepository
    {
        
    }
}
