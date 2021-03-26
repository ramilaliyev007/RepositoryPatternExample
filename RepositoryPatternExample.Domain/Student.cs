using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternExample.Domain
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
