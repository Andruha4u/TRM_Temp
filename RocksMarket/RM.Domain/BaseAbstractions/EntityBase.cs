using System;

namespace RM.Domain.BaseAbstractions
{
    public class EntityBase : IEquatable<EntityBase>
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }
        
        public EntityBase(Guid id)
        {
            Id = id;
        }
        
        public Guid Id { get; protected set; }

        public DateTime CreatedDate { get; protected set;}
        
        public Guid CreatedBy { get; protected set;}
        
        public DateTime UpdatedDate { get; protected set; }

        public Guid UpdatedBy { get; protected set;}

        public bool Equals(EntityBase other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((EntityBase) obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}