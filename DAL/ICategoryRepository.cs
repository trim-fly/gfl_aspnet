using System;
using System.Collections.Generic;
using System.Linq;
using forummvc.Models;

namespace forummvc.DAL
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetSingle(int id);
        IQueryable<Category> FetchOne(int id);
    }
}