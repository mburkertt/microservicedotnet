using api.Model;
using api.PersistenceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace api.PersistenceLayer.Services
{
    public class PersistenceLayerService : IPersistenceLayerService
    {
        private readonly PersonContext _context;

        public PersistenceLayerService(PersonContext context)
        {
            _context = context;
        }

        public void AddPerson(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return _context.Set<Person>();
        }

        public Person GetPersonByID(Guid personId)
        {
            return (Person)_context.Find(typeof(Person), personId);
        }

        public void RemovePerson(Person person)
        {
            _context.Remove(person);
            _context.SaveChanges();
        }

    }
}
