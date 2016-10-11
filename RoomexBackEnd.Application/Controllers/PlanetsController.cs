using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using RoomexBackEnd.Core.Entities;
using RoomexBackEnd.Core.Interfaces;

namespace RoomexBackEnd.Application.Controllers
{
    public class PlanetsController : ApiController
    {


        private readonly IPlanetService _planetService;

        public PlanetsController(IPlanetService planetService)
        {
            _planetService = planetService;
        }
        [ResponseType(typeof(IEnumerable<Planet>))]
        public IHttpActionResult GetPlanets()
        {
            try
            {
                var result = _planetService.GetAllPlanets();
                if (result != null && result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                var message = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(message);
            }
 

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _planetService.Dispose();
            }
            base.Dispose(disposing);
        }

 
    }
}