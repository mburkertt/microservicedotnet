using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using api.PersistenceLayer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using api.Model;

namespace api.tests.PersistenceLayer
{
    [TestClass]
    public class PersistenceLayerServiceTest
    {
        public PersistenceLayerService InitClassUnderTest()
        {
            return new PersistenceLayerService(GetContext());
        }

        public PersonContext GetContext()
        {
            return new PersonContext(GetDbContextOptions());
        }

        public DbContextOptions<PersonContext> GetDbContextOptions()
        {
            return new DbContextOptionsBuilder<PersonContext>()
                .UseInMemoryDatabase(databaseName: "testDatabase")
                .Options;
        }

        [TestMethod]
        public void Add_writes_to_database_and_read_that_it_is_the_Same_object()
        {
            var classUnderTest = InitClassUnderTest();
            Person person = new Person() { PersonId = Guid.NewGuid(), FirstName = "Hans", LastName = "Zimmer" };
            classUnderTest.AddPerson(person);

            Assert.AreEqual(person, classUnderTest.GetPersonByID(person.PersonId));
        }

        [TestMethod]
        public void Delete_object_from_db()
        {
            var classUnderTest = InitClassUnderTest();
            Person person = new Person() { PersonId = Guid.NewGuid(), FirstName = "Hans", LastName = "Zimmer" };
            classUnderTest.AddPerson(person);

            Assert.AreEqual(person, classUnderTest.GetPersonByID(person.PersonId));

            classUnderTest.RemovePerson(person);

            var secondDataBase = classUnderTest.GetPersonByID(person.PersonId);
            Assert.IsNull(secondDataBase);
        }

        [TestMethod]
        public void GetAllPersons_from_db()
        {
            var classUnderTest = InitClassUnderTest();
            Person person = new Person() { PersonId = Guid.NewGuid(), FirstName = "Hans", LastName = "Zimmer" };
            classUnderTest.AddPerson(person);

            Assert.AreEqual(person, classUnderTest.GetPersonByID(person.PersonId));

            var personList = classUnderTest.GetAllPerson();

            Assert.AreEqual(person, personList.First());
        }

    }
}
