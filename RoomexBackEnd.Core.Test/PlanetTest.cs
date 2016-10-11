using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RoomexBackEnd.Core.Entities;
using RoomexBackEnd.Core.Interfaces;
using RoomexBackEnd.Core.Services;

namespace RoomexBackEnd.Core.Test
{
    [TestClass]
    public class PlanetTest
    {
        private PlanetService _planetService;
        private List<Planet> _planets;
        [TestInitialize]
        public void TestInitialize()
        {
            var unitOfWorkMoq = new Mock<IUnitOfWork>();
            var planetQuery = new Mock<IQueries<Planet>>();
            _planets = new List<Planet>
            {
              new Planet { Name = "Mercury", PlanetId = Guid.NewGuid(), Distance = 57910000 },
                new Planet { Name = "Venus", PlanetId = Guid.NewGuid(), Distance = 108200000 },
                new Planet { Name = "Earth", PlanetId = Guid.NewGuid(), Distance = 149600000 },
                new Planet { Name = "Mars", PlanetId = Guid.NewGuid(), Distance = 227940000 },
                new Planet { Name = "Jupiter", PlanetId = Guid.NewGuid(), Distance = 778330000 },
                new Planet { Name = "Saturn", PlanetId = Guid.NewGuid(), Distance = 1424600000 },
                new Planet { Name = "Uranus", PlanetId = Guid.NewGuid(), Distance = 2873550000 },
                new Planet { Name = "Neptune", PlanetId = Guid.NewGuid(), Distance = 4501000000 },
                new Planet { Name = "Pluto", PlanetId = Guid.NewGuid(), Distance = 5945900000 }
        };
 
            unitOfWorkMoq.SetupGet(uf => uf.PlanetQueries).Returns(planetQuery.Object);
            planetQuery.Setup(pq => pq.GetAll()).Returns(_planets.AsQueryable());

            _planetService = new PlanetService(unitOfWorkMoq.Object);

        }
        [TestMethod]
        public void Get_GetAll_SetupedResult()
        {
            var result = _planetService.GetAllPlanets();
            result.Should().BeEquivalentTo(_planets);
        }
    }
}
