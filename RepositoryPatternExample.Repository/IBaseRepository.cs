using RepositoryPatternExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternExample.Repository
{
    public interface IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
        where TId : struct
    {
        void Insert(TEntity entity);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(TId id);

        void Delete(TId id);
    }

    public interface IBaseRepository<TEntity> : IBaseRepository<TEntity, int>
        where TEntity : BaseEntity
    {

    }
}
