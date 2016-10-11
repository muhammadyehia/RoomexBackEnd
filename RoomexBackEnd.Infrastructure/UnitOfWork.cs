using RoomexBackEnd.Core.Entities;
using RoomexBackEnd.Core.Interfaces;

namespace RoomexBackEnd.Infrastructure
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly PlanetContext _context;
        private IQueries<Planet> _planetQueries;
        public UnitOfWork(PlanetContext context)
        {
            _context = context;
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public bool AutoDetectChange
        {
            set { _context.Configuration.AutoDetectChangesEnabled = value; }
        }

       public IQueries<Planet> PlanetQueries => _planetQueries ?? (_planetQueries = new Queries<Planet>(_context));

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
