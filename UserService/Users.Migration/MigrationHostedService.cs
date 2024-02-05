using Microsoft.Extensions.Hosting;

namespace Users.Migration
{
    public class MigrationHostedService : IHostedService
    {

        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public MigrationHostedService(IHostApplicationLifetime hostApplicationLifetime)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
