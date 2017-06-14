using System;

namespace forummvc.Models
{
    public class Post
    {
        public int Id {get; set;}
        public string Content {get; set;}
        public User User {get; set;}
        public int UserId {get; set;}
        public Thread Thread {get; set;}
        public int ThreadId {get; set;}

    }
}