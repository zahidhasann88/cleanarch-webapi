using CleanArch.Core.Models;
using CleanArch.Infracture.Services.Product;
using CleanArch.Infracture.Services.UserAdmin;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infracture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<PostgresContext>(options =>
                     options.UseNpgsql("Host=localhost;Database=cleanarch;Username=postgres;Password=15Nov1998")
           );
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IUserAdminServices, UserAdminServices>();
            return services;
        }

    }
}