using RoomexBackEnd.Core.Entities;

namespace RoomexBackEnd.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<PlanetContext>
    {
   
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlanetContext context)
        {
            context.Planets.AddOrUpdate(p => p.Name,
                new Planet { Name = "Mercury", PlanetId = Guid.NewGuid(), Distance = 57910000 },
                new Planet { Name = "Venus", PlanetId = Guid.NewGuid(), Distance = 108200000 },
                new Planet { Name = "Earth", PlanetId = Guid.NewGuid(), Distance = 149600000 },
                new Planet { Name = "Mars", PlanetId = Guid.NewGuid(), Distance = 227940000 },
                new Planet { Name = "Jupiter", PlanetId = Guid.NewGuid(), Distance = 778330000 },
                new Planet { Name = "Saturn", PlanetId = Guid.NewGuid(), Distance = 1424600000 },
                new Planet { Name = "Uranus", PlanetId = Guid.NewGuid(), Distance = 2873550000 },
                new Planet { Name = "Neptune", PlanetId = Guid.NewGuid(), Distance = 4501000000 },
                new Planet { Name = "Pluto", PlanetId = Guid.NewGuid(), Distance = 5945900000 });


        }
    }
}
