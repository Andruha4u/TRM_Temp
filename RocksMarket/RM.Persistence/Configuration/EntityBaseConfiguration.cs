using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RM.Domain.BaseAbstractions;

namespace RM.Persistence.Configuration
{
    internal class EntityBaseConfiguration<T>: IEntityTypeConfiguration<T> where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(entity => entity.Id);
    
            // TODO: All other properties
        }
    }
}