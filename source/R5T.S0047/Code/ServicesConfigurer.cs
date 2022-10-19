using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0036.F001;


namespace R5T.S0047
{
    public class ServicesConfigurer : IServicesConfigurer
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            F0035.ServicesOperator.Instance.AddLogging(services);

            return Task.CompletedTask;
        }
    }
}
