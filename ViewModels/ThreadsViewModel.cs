using forummvc.Models;

namespace forummvc.ViewModels
{
    public class ThreadsViewModel
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public User Starter {get; set;}
        public ThreadStatus Status {get; set;}
        public int PostsCount { get; set; }
    }
}