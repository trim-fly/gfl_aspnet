using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using forummvc.DAL.Services;
using Microsoft.EntityFrameworkCore;
using forummvc.Models;

namespace forummvc.DAL
{
    public class CategoryRepository : Repository<Category, ForummvcContext>, ICategoryRepository
    {
        public CategoryRepository(ForummvcContext context): base(context)
        { }

        public Category GetSingle(int id)
        {
            return GetAll().SingleOrDefault(c => c.Id == id);
        }

        public IQueryable<Category> FetchOne(int id)
        {
            return GetAll().Where(c => c.Id == id).AsQueryable();
        }
    }
}