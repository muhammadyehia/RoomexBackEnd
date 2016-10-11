using System.Linq;

namespace RoomexBackEnd.Core.Interfaces
{
    public interface IQueries<T> where T : class
    {
        IQueryable<T> GetAll();
    }
}