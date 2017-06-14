using System;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using forummvc.Models;

namespace forummvc.DAL
{
    public class PostRepository: Repository<Post, ForummvcContext>, IPostRepository
    {
        public PostRepository(ForummvcContext context): base(context)
        { }

        public Post GetSingle(int id)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == id);
            return query;
        }
    }
}