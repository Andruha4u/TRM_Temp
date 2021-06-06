using Microsoft.EntityFrameworkCore;
using RM.Domain.Payments;
using RM.Persistence.Configuration;

namespace RM.Persistence
{
    public class MarketplaceContext : DbContext
    {
        public DbSet<UserPaymentInformation> UserPaymentInformationCollection { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserPaymentInformationConfiguration());
        }
    }
}