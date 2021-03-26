using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Domain;
using RepositoryPatternExample.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternExample.Infrastructure.Repository.EfCore
{
    public class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        protected readonly RepositoryPatternDbContext _dbContext;
        protected readonly DbSet<TEntity> _entities;

        public BaseRepository(RepositoryPatternDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._entities = dbContext.Set<TEntity>();
        }

        public virtual void Delete(TId id)
        {
            var entity = _entities.Find(id);

            _entities.Remove(entity);

            _dbContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public virtual TEntity GetById(TId id)
        {
            return _entities.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _entities.Add(entity);

            _dbContext.SaveChanges();
        }
    }

    public class BaseRepository<TEntity> : BaseRepository<TEntity, int>
        where TEntity : BaseEntity<int>
    {
        public BaseRepository(RepositoryPatternDbContext dbContext) : base(dbContext)
        {

        }
    }
}
