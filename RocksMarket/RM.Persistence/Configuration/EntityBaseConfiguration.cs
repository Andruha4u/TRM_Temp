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
    
            builder.Property(x => x.Id)
                .HasColumnType("uuid")
                .HasDefaultValueSql("uuid_generate_v4()")
                .IsRequired();        
        }
    }
}