using System;
using RoomexBackEnd.Core.Entities;

namespace RoomexBackEnd.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IQueries<Planet> PlanetQueries { get; }
        bool AutoDetectChange { set; }
        int Commit();
    }
}