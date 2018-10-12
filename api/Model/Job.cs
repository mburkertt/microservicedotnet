using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Job
    {
           public Job() { }

           public Guid JobId { get; set; }

           public IEnumerable<Guid> FilestoreIds { get; set; }

           public IEnumerable<Guid> FileIds { get; set; }

           public IEnumerable<Guid> FileInstanceIds { get; set; }
    }
}
