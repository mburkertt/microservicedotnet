using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class FileInstance
    {

        public FileInstance() { }

        public Guid FileInstanceId { get; set; }

        public Guid FileId { get; set; }
    }
}
