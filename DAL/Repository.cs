using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using forummvc.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace forummvc.DAL
{
    public abstract class Repository<T, TC> : 
        IRepository<T> where T : class
        where TC : DbContext
    {
        protected TC Context { get; }

        protected Repository(TC c)
        {
            Context = c;
        }
        public virtual void Add(T t)
        {
            Context.Set<T>().Add(t);
        }

        public virtual void Delete(T t)
        {
            Context.Set<T>().Remove(t);
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> result = Context.Set<T>();
            return result;
        }

        public virtual IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            var result = Context.Set<T>().Where(predicate);
            return result;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public virtual void Update(T t)
        {
            if (Entry(t).State == EntityState.Detached)
            {
                Entry(t).Context.Attach(t);
            }
            Entry(t).State = EntityState.Modified;
        }

        public EntityEntry<T> Entry(T t)
        {
            var x = Context.Entry(t);
            return x;
        }
    }
}