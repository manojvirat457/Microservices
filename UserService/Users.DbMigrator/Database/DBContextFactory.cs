using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Users.DbMigrator
{
    public class DBContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Users;Username=postgres;Password=Manoj1997;");

            return new DBContext(optionsBuilder.Options);
        }
    }
}
