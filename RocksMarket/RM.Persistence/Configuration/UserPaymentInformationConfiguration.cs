using System.Data.Entity.ModelConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RM.Domain.Payments;

namespace RM.Persistence.Configuration
{
    internal class UserPaymentInformationConfiguration : EntityBaseConfiguration<UserPaymentInformation>
    {
        public override void Configure(EntityTypeBuilder<UserPaymentInformation> builder)
        {
            base.Configure(builder);
        }
    }
}