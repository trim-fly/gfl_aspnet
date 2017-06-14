using System;
using System.Collections.Generic;

namespace forummvc.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string DisplayName {get; set;}
        public List<Thread> Threads {get; set;}
    }
}