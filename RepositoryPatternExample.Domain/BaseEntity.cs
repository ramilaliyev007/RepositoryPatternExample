using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternExample.Domain
{
    public class BaseEntity<TId> where TId : struct
    {
        public virtual TId Id { get; set; }
    }

    public class BaseEntity : BaseEntity<int>
    {

    }
}
