using System;
using System.Collections.Generic;

namespace forummvc.Models
{
    public enum ThreadStatus {
        Open,
        Closed
    }
    public class Thread
    {
        public int Id {get; set;}
        public string DisplayName {get; set;}
        public User Starter {get; set;}
        public int UserId {get; set;}
        public ThreadStatus Status {get; set;}
        public Category Category {get; set;}
        public int? CategoryId {get;set;}
        public List<Post> Posts {get; set;}        
    }
}