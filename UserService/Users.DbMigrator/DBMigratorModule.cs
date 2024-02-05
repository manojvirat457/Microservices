using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Users.DbMigrator
{
    public class DBMigratorModule
    {
        private IConfiguration _configuration;
        private IServiceCollection _services;

        public DBMigratorModule(IConfiguration configuration, IServiceCollection collection)
        {
            _configuration = configuration;
            _services = collection;
        }

        public void CreateDatabase()
        {
            var _appServiceProvider = _services.BuildServiceProvider();
            var context = _appServiceProvider.GetRequiredService<DBContext>();
            context.Database.EnsureCreated();
            IEnumerable<string> migrations =  context.Database.GetPendingMigrations();

            foreach (var migration in migrations)
            {
                Console.WriteLine(migration);
            }
        }

        public void InjectDependecies()
        {
            _services.AddDbContext<DBContext>(options =>
        options.UseNpgsql(_configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
