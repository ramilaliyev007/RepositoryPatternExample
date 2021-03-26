using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Domain;
using RepositoryPatternExample.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternExample.Infrastructure.Repository.EfCore
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryPatternDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Student> GetAllWithGroup()
        {
            return _entities.Include(x => x.Group).AsEnumerable();
        }
    }
}
