using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Message_Exchange_App.Application
{
    public static class ApplicationServiceRegistration
    {
        

        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Add Application services in IServiceCollection

            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
