using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TrainTravelCo.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private Managers.TripManager manager;

        public TripController()
        {
            manager = new Managers.TripManager();
        }

        [HttpGet("List")]
        public IActionResult GetList()
        {
            
            return Ok(manager.GetAllTrips());
        }

        [HttpPost]
        public IActionResult AddTrip(Models.Trip newTrip)
        {
            manager.AddTrip(newTrip);
            return Ok();    
        }
    }
}
