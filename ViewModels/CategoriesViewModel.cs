using System;
using System.Linq;

namespace forummvc.ViewModels
{
    public class CategoriesViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        public int ThreadsCount { get; set; }
    }
}