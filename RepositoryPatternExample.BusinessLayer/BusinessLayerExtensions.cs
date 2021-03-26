using Microsoft.Extensions.DependencyInjection;
using RepositoryPatternExample.BusinessLayer.Abstract;
using RepositoryPatternExample.BusinessLayer.Concrete;

namespace RepositoryPatternExample.BusinessLayer
{
    public static class BusinessLayerExtensions
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IGroupService, GroupService>();

            return services;
        }
    }
}
