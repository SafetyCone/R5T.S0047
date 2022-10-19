using System;
using System.Threading.Tasks;

using R5T.F0037;


namespace R5T.S0047
{
    partial class Program : IAsynchronousProgram
    {
        static async Task Main()
        {
            await F0037.Instances.Program
                .ConfigureServices(servicesBuilder =>
                {
                    return servicesBuilder.UseServicesConfigurer<ServicesConfigurer>();
                })
                // Audit services here, by adding services auditor services to the services collection (do not create a new one, that way those services *are* available in the application), building a throw-away service provider, getting the services auditor services, and running them.
                .Run<Program>();
        }
    }
}