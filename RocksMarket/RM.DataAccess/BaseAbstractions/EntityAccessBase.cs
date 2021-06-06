using System;
using System.Threading.Tasks;
using RM.Domain.BaseAbstractions;
using RM.Persistence;

namespace RM.DataAccess.BaseAbstractions
{
    public class EntityAccessBase<T> where T: EntityBase
    {
        private readonly MarketplaceContext _context;
        
        protected EntityAccessBase(MarketplaceContext context)
        {
            _context = context;
        }

        public async Task Append(T entity)
            => await _context.AddAsync(entity);

        public void Remove(T entity)
            => _context.Remove(entity);

        public ValueTask<T> FindAsync(Guid id)
            => _context.FindAsync<T>(id);
    }
}