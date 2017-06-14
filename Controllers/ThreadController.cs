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
    public class ThreadController : Controller
    {
        private readonly IThreadRepository _threadRepository;
        
        public ThreadController(IThreadRepository threadRepository)
        {
            _threadRepository = threadRepository;
        }

        public IActionResult Index(int? id)
        {
            var threadService = new ThreadService(_threadRepository);
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(int? categoryId)
        {
            return Created("http://google.com", new { });
        }
    }
}