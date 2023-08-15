using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Taskmanagement.Core;
using Taskmanagement.Core.Mapper;
using Taskmanagement.Infrastructure;
using Taskmanagement.Repositories.Base;
using Taskmanagement.Repositories.Interface;

namespace Taskmanagement.IoC.Configuration;

public static class ConfigurationServices
{

    public static IServiceCollection AddExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TaskmanagementDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("conn")));
        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddAutoMapper(typeof(CommmonMapper).Assembly);

        services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));
        return services;
    }



}
