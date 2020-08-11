using ProconTel.Sdk.Attributes;
using ProconTel.Sdk.Builders;
using ProconTel.Sdk.Services;
using System;
using System.Threading.Tasks;

namespace Procontel.Jwt
{
    [EndpointMetadata(Name = "Procontel.Jwt")]
    public class JwtEndpoint : IEndpointLifeTimeCycle
    {
        private readonly ILogger _logger;

        public JwtEndpoint(ILogger logger)
        {
            _logger = logger;
        }
        public Task InitializeAsync()
        {
            _logger.Information("Jwt initalized");
            return Task.CompletedTask;
        }

        public Task TerminateAsync()
        {
            _logger.Information("Jwt terminated");
            return Task.CompletedTask;
        }
    }
}
