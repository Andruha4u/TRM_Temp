using System;
using System.Threading.Tasks;
using RM.Domain.BaseAbstractions;

namespace RM.DataAccess.BaseAbstractions
{
    public interface IEntityAccess<T> where T : EntityBase
    {
        Task Append(T entity);
        void Remove(T entity);
        ValueTask<T> FindAsync(Guid id);
    }
}