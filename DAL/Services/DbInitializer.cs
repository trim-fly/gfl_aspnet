using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using forummvc.Models;

namespace forummvc.DAL.Services
{
    public class DbInitializer
    {
        private readonly ForummvcContext _context;
        public DbInitializer(ForummvcContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Categories.Any())
            {
                return; // stop doing anything if db is not empty
            }
            // prepare predefine objects for database
            var categories = new[]
            {
                new Category {Id = 0, DisplayName = "Category One"},
                new Category {Id = 1, DisplayName = "Category Two"}
            };
            
            var users = new[]
            {
                new User
                {
                    Id = 0,
                    Password = "passwd",
                    Status = UserStatus.Active,
                    Username = "user_one",
                    UserData = new UserData
                    {
                        Id = 0,
                        DisplayName = "User One",
                        RegistrationDate = DateTime.Now,
                        UserId = 0
                    }
                },
                new User
                {
                    Id = 1,
                    Password = "passwd",
                    Status = UserStatus.Active,
                    Username = "user_two",
                    UserData = new UserData
                    {
                        Id = 1,
                        DisplayName = "User Two",
                        RegistrationDate = DateTime.Now,
                        UserId = 1
                    }
                }
            };

            var threads = new[]
            {
                new Thread{CategoryId = categories[0].Id, DisplayName="thread one", Category=categories[0], Starter=users[0], UserId=users[0].Id, Status=ThreadStatus.Open,
                    Posts = new List<Post>() },
                new Thread{CategoryId = categories[0].Id, DisplayName="thread two", Category=categories[0], Starter=users[1], UserId=users[1].Id, Status=ThreadStatus.Open,
                    Posts = new List<Post>() },
                new Thread{CategoryId = categories[1].Id, DisplayName="thread one", Category=categories[1], Starter=users[0], UserId=users[0].Id, Status=ThreadStatus.Open,
                    Posts = new List<Post>() },
                new Thread{CategoryId = categories[1].Id, DisplayName="thread two", Category=categories[1], Starter=users[1], UserId=users[1].Id, Status=ThreadStatus.Open,
                    Posts = new List<Post>() },
            };

            var Posts = new []
            {
                new Post{ ThreadId = threads[0].Id,  }
            }
        }
    }
}