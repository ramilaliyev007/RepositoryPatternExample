using RepositoryPatternExample.Domain;
using RepositoryPatternExample.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternExample.Infrastructure.Repository.EfCore
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(RepositoryPatternDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Group> SearchByCode(string code)
        {
            return _entities.Where(x => x.Code.Contains(code)).AsEnumerable();
        }

        public override void Insert(Group entity)
        {
            entity.Code = entity.Code.ToUpper();

            base.Insert(entity);
        }
    }
}
