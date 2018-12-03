using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    public class Person
    {
        public Person() { }

        public Guid PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
