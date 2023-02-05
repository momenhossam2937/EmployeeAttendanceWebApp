using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EmployeeAttendanceWebApp.Domain.Repositories.BaseRepository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        Task<TEntity> GetAsync(TKey id, CancellationToken cancellationToken = default);
        Task<List<TEntity>> GetListAsync(CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity);
        Task UpdateRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        IUnitOfWork UnitOfWork { get; }
    }
}
