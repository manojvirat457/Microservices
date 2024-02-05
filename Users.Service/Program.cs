using Microsoft.AspNetCore.Hosting;
using Users.Service;

var builder = WebApplication.CreateBuilder(args);

UserServiceModule.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();
UserServiceModule.ConfiguresApps(app);

app.Run();