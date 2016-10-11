using System;
using System.Data.Entity;
using System.Linq;
using RoomexBackEnd.Core.Interfaces;

namespace RoomexBackEnd.Infrastructure
{
    public class Queries<T> : IQueries<T> where T : class
    {
        private readonly DbContext _context;
        public Queries(DbContext context)
        {
            _context = context;
        }
        public IQueryable<T> GetAll()
        {
            try
            {
                return _context.Set<T>().AsNoTracking();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
          
        }

    }
}
