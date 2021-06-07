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
                .HasColumnType(PersistenceResources.Guid_Type)
                .HasDefaultValueSql(PersistenceResources.Default_Id_Value)
                .IsRequired();        
        }
    }
}