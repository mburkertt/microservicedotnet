using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.PersistenceLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class PersonFormController : Controller
    {
        private readonly IPersistenceLayerService _persistenceLayerService;

        public PersonFormController(IPersistenceLayerService persistenceLayerService)
        {
            _persistenceLayerService = persistenceLayerService;
        }

        public ActionResult PersonForm()
        {
            return View();
        }

        // POST api/values
        [HttpPost]
        public ActionResult PersonForm(Person person)
        {
            Guid personId = person.PersonId;
            string firstName = person.FirstName;
            string lastName = person.LastName;
            _persistenceLayerService.AddPerson(person);
            return View();
        }

    }
}
