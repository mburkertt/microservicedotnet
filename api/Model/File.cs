using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class File
    {

        public File() { }

        public Guid FileId { get; set; }

        public IEnumerable<Guid> FileInstanceIds { get; set; }
}
}
