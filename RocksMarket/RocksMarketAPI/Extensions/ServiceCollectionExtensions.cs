using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RM.Persistence;

namespace RocksMarketAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRocksMarketDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<MarketplaceContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("RocksMarketplace"));
            });
        }
    }
}