using Microsoft.EntityFrameworkCore;
using Users.Model;

namespace Users.DbMigrator
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) {}

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
    }
}
