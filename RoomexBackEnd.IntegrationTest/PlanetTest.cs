using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomexBackEnd.Application.Controllers;
using RoomexBackEnd.Core.Entities;
using RoomexBackEnd.Core.Interfaces;
using RoomexBackEnd.Core.Services;
using RoomexBackEnd.Infrastructure;

namespace RoomexBackEnd.IntegrationTest
{
    [TestClass]
    public class PlanetTest
    {
        private PlanetService _planetService;
        private List<Planet> _planets;
        private PlanetsController _planetsController;
        private PlanetContext _planetContext;
        [TestInitialize]
        public void TestInitialize()
        {
            var configuration = new Infrastructure.Migrations.Configuration();
            var migrator = new DbMigrator(configuration);
            migrator.Update();
        }

        public PlanetTest()
        {
            _planetContext = new PlanetContext();
            var unitOfWork = new UnitOfWork(_planetContext);
            _planetService = new PlanetService(unitOfWork);
            _planetsController = new PlanetsController(_planetService);
            _planets = new List<Planet>
            {
                new Planet { Name = "Mercury",  Distance = 57910000 , PlanetId=Guid.Empty},
                new Planet { Name = "Venus",  Distance = 108200000, PlanetId=Guid.Empty },
                new Planet { Name = "Earth",  Distance = 149600000 , PlanetId=Guid.Empty},
                new Planet { Name = "Mars",  Distance = 227940000, PlanetId=Guid.Empty },
                new Planet { Name = "Jupiter", Distance = 778330000 , PlanetId=Guid.Empty},
                new Planet { Name = "Saturn", Distance = 1424600000, PlanetId=Guid.Empty },
                new Planet { Name = "Uranus", Distance = 2873550000, PlanetId=Guid.Empty },
                new Planet { Name = "Neptune", Distance = 4501000000 , PlanetId=Guid.Empty},
                new Planet { Name = "Pluto", Distance = 5945900000, PlanetId=Guid.Empty }
            };
        }
        [TestMethod]
        public void Get_GetAll_SetupedResult()
        {
            IHttpActionResult actionResult = _planetsController.GetPlanets();
            var contentResult = actionResult as OkNegotiatedContentResult<IEnumerable<Planet>>;
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            contentResult.Content.Select(p => new Planet { Name = p.Name, Distance = p.Distance, PlanetId = Guid.Empty }).Should().BeEquivalentTo(_planets);
        }
    }
}
