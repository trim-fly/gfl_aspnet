using System;
using System.Linq;
using forummvc.Models;

namespace forummvc.DAL.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _cr;
        public CategoryService(ICategoryRepository cr)
        {
            _cr = cr;
        }

        public int GetCategoriesCount()
        {
            return _cr.GetAll().Count();
        }

        public int ThreadsCountInCategory(Category c)
        {
            return _cr.GetAll().Where(cat => cat.Id == c.Id).SelectMany(cat => cat.Threads).Count(t => t.Status == ThreadStatus.Open);
        }
    }
}