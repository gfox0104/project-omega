using EnvironmentSettings.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OmegaPlumbing;

namespace OmegaService.Core
{
    public class CoreService : ProjectOmegaService
    {
        public override void ConfigureServices(IServiceCollection services, ILogger logger, IEnvSettings envSettings)
        {
        }
        
        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
}