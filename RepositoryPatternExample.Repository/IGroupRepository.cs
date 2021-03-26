using RepositoryPatternExample.Domain;
using System.Collections.Generic;

namespace RepositoryPatternExample.Repository
{
public interface IGroupRepository : IBaseRepository<Group>
{
    IEnumerable<Group> SearchByCode(string code);
}
}
