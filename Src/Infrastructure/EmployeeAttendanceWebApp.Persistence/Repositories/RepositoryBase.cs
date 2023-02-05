using EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EmployeeAttendanceWebApp.Persistence.Repositories
{
    public class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        public IUnitOfWork UnitOfWork => _context;

        protected readonly DbSet<TEntity> _entities;

        public RepositoryBase(ApplicationDbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(TKey id, CancellationToken cancellationToken = default)
        {
            var entity = await _entities.FindAsync(new object[] { id }, cancellationToken);
            return entity;
        }

        public Task<List<TEntity>> GetListAsync(CancellationToken cancellationToken = default)
        {
            return _entities.ToListAsync(cancellationToken);
        }

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _entities.AddAsync(entity, cancellationToken);
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            return _entities.AddRangeAsync(entities, cancellationToken);
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return _entities.AnyAsync(predicate, cancellationToken);
        }

        public Task UpdateAsync(TEntity entity)
        {
            _entities.Update(entity);

            return Task.CompletedTask;
        }

        public Task UpdateRangeAsync(IEnumerable<TEntity> entities)
        {
            _entities.UpdateRange(entities);

            return Task.CompletedTask;
        }

        public Task RemoveAsync(TEntity entity)
        {
            _entities.Remove(entity);

            return Task.CompletedTask;
        }
    }
}
