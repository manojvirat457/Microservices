using Microsoft.EntityFrameworkCore;
using Users.DbMigrator;
using Users.Repository;

namespace Users.Service
{
    public static class UserServiceModule
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            InjectDependencies(services, configuration);
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void ConfiguresApps(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            CreateDatabase(app);

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

        private static void CreateDatabase(WebApplication app)
        {
            using (var serviceScope = app.Services.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DBContext>();
                context.Database.EnsureCreated();
            }
        }

        private static void InjectDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContext>(options =>
        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
        }
    }
}
