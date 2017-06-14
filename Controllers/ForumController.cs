using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using forummvc.Models;
using forummvc.DAL;
using Microsoft.EntityFrameworkCore;
using forummvc.ViewModels;
using System.ComponentModel.DataAnnotations;
using forummvc.DAL.Services;

namespace forummvc.Controllers
{
    public class ForumController : Controller
    {
        private readonly IThreadRepository _threadRepository;
        
        public ForumController(IThreadRepository threadRepository)
        {
            _threadRepository = threadRepository;
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var threadService = new ThreadService(_threadRepository);
            ThreadsViewModel thrvm = new ThreadsViewModel()
            {
                Id = 0,
                PostsCount = 0,
                Starter = null,
                Status = ThreadStatus.Open,
                Title = "Theme 0"
            };
            return View(new List<ThreadsViewModel>{thrvm});
        }
    }
}