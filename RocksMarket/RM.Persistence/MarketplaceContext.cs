using Microsoft.EntityFrameworkCore;
using RM.Domain.Payments;
using RM.Persistence.Configuration;

namespace RM.Persistence
{
    public class MarketplaceContext : DbContext
    {

        public MarketplaceContext(DbContextOptions<MarketplaceContext> options) : base(options)
        {
        }
        
        public DbSet<UserPaymentInformation> UserPaymentInformation { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserPaymentInformationConfiguration).Assembly);
        }
    }
}