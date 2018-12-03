using api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.PersistenceLayer.Interfaces
{
    public interface IPersistenceLayerService
    {
        IEnumerable<Person> GetAllPerson();

        Person GetPersonByID(Guid personId);

        void AddPerson(Person person);

        void RemovePerson(Person person);
    }
}
