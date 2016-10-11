using System;
using System.Collections.Generic;
using System.Linq;
using RoomexBackEnd.Core.Entities;
using RoomexBackEnd.Core.Interfaces;

namespace RoomexBackEnd.Core.Services
{
    public class PlanetService : IPlanetService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlanetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _unitOfWork.AutoDetectChange = true;
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            try
            {
                return _unitOfWork.PlanetQueries.GetAll().OrderBy(p => p.Distance).AsEnumerable();
            }
            catch (Exception ex )
            {
                throw ex;
            }
            
        }

   
    }
}
