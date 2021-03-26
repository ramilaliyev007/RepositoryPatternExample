using RepositoryPatternExample.Domain;
using System.Collections.Generic;

namespace RepositoryPatternExample.Repository
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        IEnumerable<Student> GetAllWithGroup();
    }
}
