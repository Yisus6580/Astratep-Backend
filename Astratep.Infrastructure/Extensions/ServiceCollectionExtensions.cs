using Astratep.Domain.Repositories;
using Astratep.Infrastructure.Persistence;
using Astratep.Infrastructure.Repositories;
using Astratep.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Astratep.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AstratepDb");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IAffiliateSeeders, AffiliateSeeders>();
            services.AddScoped<IAffiliatesRepository, AffiliatesRepository>();
        }
    }
}
