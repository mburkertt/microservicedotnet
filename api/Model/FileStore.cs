using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class FileStore
    {

        public FileStore() { }

        public Guid FilestoreId { get; set; }

        public IEnumerable<FileInstance> FileInstances { get; set; }
    }
}
