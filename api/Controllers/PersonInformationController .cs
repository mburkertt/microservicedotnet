using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using api.PersistenceLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class PersonInformationController : Controller
    {
        private readonly IPersistenceLayerService _persistenceLayerService;

        public PersonInformationController(IPersistenceLayerService persistenceLayerService)
        {
            _persistenceLayerService = persistenceLayerService;
        }

        public ActionResult PersonInformation()
        {
            var jsonString = JsonConvert.SerializeObject(_persistenceLayerService.GetAllPerson());
            ViewBag.Message = jsonString;

            return View();
        }

    }
}
