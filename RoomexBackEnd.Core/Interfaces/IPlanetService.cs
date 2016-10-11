using System;
using System.Collections.Generic;
using RoomexBackEnd.Core.Entities;

namespace RoomexBackEnd.Core.Interfaces
{
    public interface IPlanetService : IDisposable
    {
        IEnumerable<Planet> GetAllPlanets();
    }
}