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
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(ICategoryRepository cr)
        {
            _categoryRepository = cr;
        }
        public IActionResult Index()
        {
            var catService = new CategoryService(_categoryRepository);
            var categories = _categoryRepository.GetAll()
                .ToList()
                .Select(category => new CategoriesViewModel
                {
                    Id = category.Id,
                    Title = category.DisplayName,
                    ThreadsCount = catService.ThreadsCountInCategory(category)
                })
                .ToList();

            
/*            var categories = _categoryRepository.GetAll().SelectMany(x => x.Threads,
                    (cat, thr) => new 
                    {
                        ID = cat.ID,
                        Title = cat.DisplayName,
                        Count = cat.Threads.Count(t => t.Status == ThreadStatus.Open)
                    })
                .Distinct()
                .ToList() // stop doing sql query, next just generate viewmodel objects
                .Select(a => new CategoriesViewModel
                {
                    Id = a.ID,
                    Title = a.Title,
                    ThreadsCount = a.Count
                }).ToList();
*/
            return View(categories);
        }
    }
}
