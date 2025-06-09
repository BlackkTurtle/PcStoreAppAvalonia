using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PcStore.DAL.Persistence;
using PcStore.DAL.Repositories.Contracts;
using PcStore.DAL.Specification;
using PcStore.DAL.Specification.Evaluator;

namespace PCStore.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        protected readonly DbSet<T> _dbSet;
        private readonly PcstoreContext _dbContext;

        protected GenericRepository(PcstoreContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        public T Create(T entity)
        {
            return _dbContext.Set<T>().Add(entity).Entity;
        }

        public async Task<T> CreateAsync(T entity)
        {
            var tmp = await _dbContext.Set<T>().AddAsync(entity);
            return tmp.Entity;
        }

        public Task CreateRangeAsync(IEnumerable<T> items)
        {
            return _dbContext.Set<T>().AddRangeAsync(items);
        }

        public EntityEntry<T> Update(T entity)
        {
            return _dbContext.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> items)
        {
            _dbContext.Set<T>().UpdateRange(items);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            _dbContext.Set<T>().RemoveRange(items);
        }

        public void Attach(T entity)
        {
            _dbContext.Set<T>().Attach(entity);
        }

        public EntityEntry<T> Entry(T entity)
        {
            return _dbContext.Entry(entity);
        }

        public void Detach(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Detached;
        }

        public Task ExecuteSqlRaw(string query)
        {
            return _dbContext.Database.ExecuteSqlRawAsync(query);
        }

        public async Task<IEnumerable<TResult>> GetAllAsync<TResult>(IBaseSpecification<T, TResult> specification)
        {
            return await ApplySpecificationForList(specification).ToListAsync();
        }

        public async Task<TResult> GetFirstOrDefaultAsync<TResult>(IBaseSpecification<T, TResult> specification)
        {
            return await ApplySpecificationForList(specification).FirstOrDefaultAsync();
        }

        private IQueryable<TResult> ApplySpecificationForList<TResult>(IBaseSpecification<T, TResult> specification)
        {
            return SpecificationEvaluator<T, TResult>.GetQuery(_dbSet.AsQueryable(), specification);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}