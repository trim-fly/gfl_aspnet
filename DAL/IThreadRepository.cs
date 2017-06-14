using System.Linq;
using forummvc.Models;

namespace forummvc.DAL
{
    public interface IThreadRepository : IRepository<Thread>
    {
        Thread GetSingle(int id);
        IQueryable<Thread> FetchOne(int id);
    }
}