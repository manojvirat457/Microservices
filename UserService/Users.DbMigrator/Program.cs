using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Users.DbMigrator;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

IHost host = builder.Build();

var module = new DBMigratorModule(builder.Configuration, new ServiceCollection());
module.InjectDependecies();
module.CreateDatabase();
host.Run();