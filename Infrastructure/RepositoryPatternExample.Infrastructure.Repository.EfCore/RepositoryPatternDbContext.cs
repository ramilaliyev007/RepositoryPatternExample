using Microsoft.EntityFrameworkCore;
using RepositoryPatternExample.Domain;

namespace RepositoryPatternExample.Infrastructure.Repository.EfCore
{
    public class RepositoryPatternDbContext : DbContext
    {
        public RepositoryPatternDbContext(DbContextOptions<RepositoryPatternDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
