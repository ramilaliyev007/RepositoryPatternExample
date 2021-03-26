using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternExample.Repository;

namespace RepositoryPatternExample.Infrastructure.Repository.EfCore
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddEfCore(this IServiceCollection services, IConfiguration configuration)
        {
            AddDbContext(services, configuration);
            RegisterDependencies(services);

            return services;
        }

        private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryPatternDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("RepositoryPatternExample")));
        }

        private static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
        }
    }
}
