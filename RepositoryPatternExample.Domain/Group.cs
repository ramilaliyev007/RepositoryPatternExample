using System.Collections.Generic;

namespace RepositoryPatternExample.Domain
{
    public class Group : BaseEntity
{
    public Group()
    {
        this.Students = new List<Student>();
    }

    public string Name { get; set; }
    public string Code { get; set; }

    public ICollection<Student> Students { get; set; }
}
}
