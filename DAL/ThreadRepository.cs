using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using forummvc.Models;

namespace forummvc.DAL
{
    public class ThreadRepository: Repository<Thread, ForummvcContext>, IThreadRepository
    {
        public ThreadRepository(ForummvcContext context): base(context)
        { }

        public Thread GetSingle(int id)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == id);
            return query;
        }

        public IQueryable<Thread> FetchOne(int id)
        {
            var query = GetBy(t => t.Id == id);
            return query;
        }
    }
}