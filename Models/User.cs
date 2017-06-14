using System;
using System.Collections.Generic;

namespace forummvc.Models
{
    public enum UserStatus {
        Active,
        Disabled,
        Deleted
    }
    public class User
    {
        public int Id {get; set;}
        public string Username {get; set;}
        public string Password {get; set;}
        public UserStatus Status {get; set;}
        public UserData UserData {get; set;}

        public List<Thread> Threads {get; set;}
    }
}