using forummvc.Models;

namespace forummvc.DAL
{
    internal interface IPostRepository : IRepository<Post>
    {
        Post GetSingle(int id);
    }
}