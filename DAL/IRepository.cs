using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using forummvc.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace forummvc.DAL
{
    public interface IRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        EntityEntry<T> Entry(T t);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        void Save();
    }
}